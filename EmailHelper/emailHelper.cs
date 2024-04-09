using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Configuration;


namespace EmailHelper
{
    public static class emailHelper
    {
        public static string SendEmail(string email)
        {
            var mailPWD = System.Configuration.ConfigurationManager.AppSettings["mailPWD"].ToString();
            var mailAddress = System.Configuration.ConfigurationManager.AppSettings["mailAddress"].ToString();

            MailMessage message = new MailMessage();

            //发件人地址
            message.From = new MailAddress(mailAddress, "hhh");

            //收件人地址
            message.To.Add(new MailAddress(email));

            message.Subject = "⌓‿⌓";

            Random rand = new Random();
            var num = rand.Next(10000, 99999);

            message.Body = $"感谢使用本系统,验证码为{num}";

            using (SmtpClient client = new SmtpClient())
            {
                client.Host = "smtp.qq.com";
                client.Port = 587;
                client.EnableSsl = true;

                client.Credentials = new System.Net.NetworkCredential(mailAddress, mailPWD);
                client.DeliveryMethod = SmtpDeliveryMethod.Network;

                client.Send(message);
            }
            return num.ToString();
        }
    }
}
