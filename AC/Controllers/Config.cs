using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace AC.Controllers
{
    public class Config
    {
        public static string alipay_public_key = @"MIIBIjANBgkqhkiG9w0BAQEFAAOCAQ8AMIIBCgKCAQEAmToLcqO1vyu3r2TrqhbWFZGUb1rIUPRuPfgYtDSUXDIDbBXa9LasZnTQObYlv+wZtJfcLzYon+Lxr375jkDs/hrbaOfn4m2ZFsSAri8FDkDYrqqgnGt/PFIMZldZ1viE1Z+aAfYgVukweJxvBzUs6cMvYQtP5rJuwFOXQTEiX37piyNyfGbPlcPvb/wic0pwnlereW18MfXPxGV8I4irxhALS7SG+wH3X7r6TKvi/9rjBMX51WYAwd3KFH01P5+OC63gYqHvc4InGXKSAVBIspwedoHbuNuivTsox+vPDxSpa6rFUN7NI4/7MzvpZtk85q/msiY3XqyEWqEv7nPCRwIDAQAB";


        //这里要配置没有经过的原始私钥

        //开发者私钥
        public static string merchant_private_key = @"MIIEowIBAAKCAQEArTTvZPdz+I5zUDYWJLnWC5DksIEyhDQfvFgVT/njMJbB/OUm0UfnbGKy8P8A12nAuYwtDl8oCK/y23FxpAN4wzF99IqwDg0lw9/9HcGntn/68+QxYjfbtaMNpYUmu3Aex3CrH72V+PQSSFBEhz/zFIbKwBDNHFFIrDTJLZr+Qjob+Lauh94TOETNBXulJYNoQ7QtRYnLTa7g2Dd2KFIb0BANLGuixv56mUzG9jGYmUOS92a3rVJGuo24x86Cc6mcwoB72ujT/qvEY7ClHyqMxvx8Mcwbb52PqtaQbg51vlzYb8U4RjVbJHy1HJxQiayymxHFI+KA1D9k/QMqgEqb2wIDAQABAoIBAHlRqpy99q0SmhKEz93JjPNs+cHnvMp89/2kdMkf7tIJxrasixPrmV2BhHTpKF255RQR6z01yYTMOP8b5s1K4TtXXzH6MnalHt6j9VbyXdamrdBG9ZAmL+551wUozohbcDOh5zrEQFewHV4pWtahJFIsV7dQDVrYVF7KWl9nQNCBWrAj0RoMGK107PjaJL2cWWHEWnb8O91KfSQDL2jyWndS6sInQ/55/PBZH299rxCffdjrsKu6HGl8X5Nlp6mtRT07dKuY3SzYJAPAtShAbLiulMtIBVobOSz7W7sovK+37K6YnOgyHutgiwhv2go+DLAv8r5CE8DrmC0VY0N0XQECgYEA6TF6+OMqbDSgwEHa28falZ+3Ogpw9w3nH+9N92ttjmaJMFnwLo5mIuT9jC4sIblCy+A7Sbqohbi7YkYSuT/1hLOmUMMUcBvOyPln4OHnITA7TmWplmOZekcrt5OeVW4jmnRtWYIrFlvSAlD2ogs2PwC2W0zpgUO2HUsE0LhEaEkCgYEAviWOr61Ij8LfmN4AGOpeXcKbQ731qB3WaxRGobzLMS8YkCVGr1ks2Kw+uSv5hABP7tcMrlSTwg7M2CinM5FHJos8Cu5aAeFREKy76ZObSKY3sKRyBRRmfFCMA6WtpqVpiROsZVHU3qE68nSWaNaqbw/kL6wGunvthgS5G0VwSwMCgYAPXFgKXwRjXlAcefoNsit+4adzJk7spzjLTLspCiWMVMrCqZn9pxmpQMZG3p+/lPGGdn3RTH9fV5zYS19eXo0wsZjKBx+ohtxnNq6WDKtp70Bo2J+ELYllmZySmiG65OdpfDPbyoxGC8RYrLaiU/S9z7EzcGyNPEWZxmBJ02mGKQKBgQCgmuJxOkDuxJ/N471bTiJUuXohdsKWtFUWbrLWC7vomCn8HrAcjYrWnG4CQ8VmHElnqBaa7O882vlknrnTUaMySCp35Sj7K5AoMG4r9TQU4ehp+AwihD+oQvRwZDFPb6m7UXWswri1LqO2hIlClgaw9lA7f+bS/rf6GeUrxrP5dwKBgCO2Vl+fHroSFdx6Dn6d/lEm1BKq0OPr7mZkjnHAlzkW38JJ8eVuy19lWAQ945E65ofHgrhZkEEbZ0g+kD4EZyxoYoS42Aa7/e5utTerZO+r84RJHV6GcZkZR3NAq+U9AJsI57QpzmNfrp324aw51U5xP/v0ORlVCp59xMFo9C7b";

        //开发者公钥
        public static string merchant_public_key = @"MIIBIjANBgkqhkiG9w0BAQEFAAOCAQ8AMIIBCgKCAQEArTTvZPdz+I5zUDYWJLnWC5DksIEyhDQfvFgVT/njMJbB/OUm0UfnbGKy8P8A12nAuYwtDl8oCK/y23FxpAN4wzF99IqwDg0lw9/9HcGntn/68+QxYjfbtaMNpYUmu3Aex3CrH72V+PQSSFBEhz/zFIbKwBDNHFFIrDTJLZr+Qjob+Lauh94TOETNBXulJYNoQ7QtRYnLTa7g2Dd2KFIb0BANLGuixv56mUzG9jGYmUOS92a3rVJGuo24x86Cc6mcwoB72ujT/qvEY7ClHyqMxvx8Mcwbb52PqtaQbg51vlzYb8U4RjVbJHy1HJxQiayymxHFI+KA1D9k/QMqgEqb2wIDAQAB";

        //应用ID
        public static string appId = "2021000121697901";

        //合作伙伴ID：partnerID
        public static string pid = "2088621993937434";


        //支付宝网关
        public static string serverUrl = "https://openapi.alipaydev.com/gateway.do";
        public static string mapiUrl = "https://mapi.alipaydev.com/gateway.do";
        public static string monitorUrl = "http://mcloudmonitor.com/gateway.do";

        //编码，无需修改
        public static string charset = "utf-8";
        //签名类型，支持RSA2（推荐！）、RSA
        //public static string sign_type = "RSA2";
        public static string sign_type = "RSA2";
        //版本号，无需修改
        public static string version = "1.0";


        /// <summary>
        /// 公钥文件类型转换成纯文本类型
        /// </summary>
        /// <returns>过滤后的字符串类型公钥</returns>
        public static string getMerchantPublicKeyStr()
        {
            StreamReader sr = new StreamReader(merchant_public_key);
            string pubkey = sr.ReadToEnd();
            sr.Close();
            if (pubkey != null)
            {
                pubkey = pubkey.Replace("-----BEGIN PUBLIC KEY-----", "");
                pubkey = pubkey.Replace("-----END PUBLIC KEY-----", "");
                pubkey = pubkey.Replace("\r", "");
                pubkey = pubkey.Replace("\n", "");
            }
            return pubkey;
        }

        /// <summary>
        /// 私钥文件类型转换成纯文本类型
        /// </summary>
        /// <returns>过滤后的字符串类型私钥</returns>
        public static string getMerchantPriveteKeyStr()
        {
            StreamReader sr = new StreamReader(merchant_private_key);
            string pubkey = sr.ReadToEnd(); 
            sr.Close();
            if (pubkey != null)
            {
                pubkey = pubkey.Replace("-----BEGIN PUBLIC KEY-----", "");
                pubkey = pubkey.Replace("-----END PUBLIC KEY-----", "");
                pubkey = pubkey.Replace("\r", "");
                pubkey = pubkey.Replace("\n", "");
            }
            return pubkey;
        }

    }
}