using Com.Alipay;
using Com.Alipay.Business;
using Com.Alipay.Domain;
using Com.Alipay.Model;
using FoodManage;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using ThoughtWorks.QRCode.Codec;

namespace AC.Controllers
{
    public class PayController : Controller
    {
        IAlipayTradeService serviceClient = F2FBiz.CreateClientInstance(Config.serverUrl, Config.appId, Config.merchant_private_key, Config.version,
                            Config.sign_type, Config.alipay_public_key, Config.charset);
        // GET: Pay
        public ActionResult Paypage()
        {
            return View();
        }

        public JsonResult F2FPay(string Id,string money,string subject)
        {
            AlipayTradePrecreateContentBuilder builder = BuildPrecreateContent(Id,money,subject);
            string out_trade_no = builder.out_trade_no;

            //如果需要接收扫码支付异步通知，那么请把下面两行注释代替本行。
            //推荐使用轮询撤销机制，不推荐使用异步通知,避免单边账问题发生。
            AlipayF2FPrecreateResult precreateResult = serviceClient.tradePrecreate(builder);
            //string notify_url = "http://10.5.21.14/notify_url.aspx";  //商户接收异步通知的地址
            //AlipayF2FPrecreateResult precreateResult = serviceClient.tradePrecreate(builder, notify_url);

            //以下返回结果的处理供参考。
            //payResponse.QrCode即二维码对于的链接
            //将链接用二维码工具生成二维码打印出来，顾客可以用支付宝钱包扫码支付。
            string result = "";

            switch (precreateResult.Status)
            {
                case ResultEnum.SUCCESS:
                    var url=DoWaitProcess(precreateResult);
                    var src = $@"<img id = ""ImageP"" Height = ""255"" Width = ""249"" src=""{url}"" />";
                    return Json(url);
                    break;
                case ResultEnum.FAILED:
                    result = precreateResult.response.Body;
                    Response.Redirect("result.aspx?Text=" + result);
                    break;

                case ResultEnum.UNKNOWN:
                    if (precreateResult.response == null)
                    {
                        result = "配置或网络异常，请检查后重试";
                        
                    }
                    else
                    {
                        result = "系统异常，请更新外部订单后重新发起请求";
                        
                    }
                    return Json(result);
                    break;
            }

            return Json("生成成功");
        }

        /// <summary>
        /// 构造支付请求数据
        /// </summary>
        /// <returns>请求数据集</returns>
        private AlipayTradePrecreateContentBuilder BuildPrecreateContent(string Id, string money, string subject)
        {
            //线上联调时，请输入真实的外部订单号。
            


            AlipayTradePrecreateContentBuilder builder = new AlipayTradePrecreateContentBuilder();
            //收款账号
            builder.seller_id = Config.pid;
            //订单编号
            builder.out_trade_no = Id;
            //订单总金额
            builder.total_amount = money;
            //参与优惠计算的金额
            //builder.discountable_amount = "";
            //不参与优惠计算的金额
            //builder.undiscountable_amount = "";
            //订单名称
            builder.subject = subject;
            //自定义超时时间
            builder.timeout_express = "5m";
            //订单描述
            builder.body = "";
            //门店编号，很重要的参数，可以用作之后的营销
            builder.store_id = "test store id";
            //操作员编号，很重要的参数，可以用作之后的营销
            builder.operator_id = "test";

            //传入商品信息详情
            List<GoodsInfo> gList = new List<GoodsInfo>();
            GoodsInfo goods = new GoodsInfo();
            goods.goods_id = "goods id";
            goods.goods_name = "goods name";
            goods.price = "0.01";
            goods.quantity = "1";
            gList.Add(goods);
            builder.goods_detail = gList;

            //系统商接入可以填此参数用作返佣
            //ExtendParams exParam = new ExtendParams();
            //exParam.sysServiceProviderId = "20880000000000";
            //builder.extendParams = exParam;

            return builder;

        }

        /// <summary>
        /// 生成二维码并展示到页面上
        /// </summary>
        /// <param name="precreateResult">二维码串</param>
        private string DoWaitProcess(AlipayF2FPrecreateResult precreateResult)
        {
            //打印出 preResponse.QrCode 对应的条码
            Bitmap bt;
            string enCodeString = precreateResult.response.QrCode;
            QRCodeEncoder qrCodeEncoder = new QRCodeEncoder();
            qrCodeEncoder.QRCodeEncodeMode = QRCodeEncoder.ENCODE_MODE.BYTE;
            qrCodeEncoder.QRCodeErrorCorrect = QRCodeEncoder.ERROR_CORRECTION.H;
            qrCodeEncoder.QRCodeScale = 3;
            qrCodeEncoder.QRCodeVersion = 8;
            bt = qrCodeEncoder.Encode(enCodeString, Encoding.UTF8);
            string filename = System.DateTime.Now.ToString("yyyyMMddHHmmss") + "0000" + (new Random()).Next(1, 10000).ToString()
             + ".jpg";
            bt.Save(Server.MapPath("/Image/") + filename);
            return "/Image/" + filename;

            //轮询订单结果
            //根据业务需要，选择是否新起线程进行轮询
            //ParameterizedThreadStart ParStart = new ParameterizedThreadStart(LoopQuery);
            //Thread myThread = new Thread(ParStart);
            //object o = precreateResult.response.OutTradeNo;
            //myThread.Start(o);

        }

        public JsonResult AddCustomer(string id, string name, string address, string tel)
        {
            new FoodMan().AddCustomer(id, name,address,tel);
            return Json("添加成功");
        }


    }
}