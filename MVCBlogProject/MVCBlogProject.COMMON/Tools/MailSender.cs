using System.Net.Mail;

namespace MVCBlogProject.COMMON.Tools
{
    public class MailSender
    {
        //Kullanım örneği MailSender.SendEmail("email adresi", "konu başlığı", "mail içeriği")
        public static void SendEmail(string email, string subject, string message)
        {
            MailMessage sender = new MailMessage();
            sender.From = new MailAddress("web@ramx.net", "MVC Blog");
            sender.To.Add(email);
            sender.Subject = subject;
            sender.Body = message;

            SmtpClient smtp = new SmtpClient();

            smtp.Credentials = new System.Net.NetworkCredential("web@ramx.net", "PYoe45N5");
            smtp.Port = 587;
            smtp.Host = "mail.ramx.net";
            smtp.EnableSsl = false;
            smtp.Send(sender);
        }
    }
}
