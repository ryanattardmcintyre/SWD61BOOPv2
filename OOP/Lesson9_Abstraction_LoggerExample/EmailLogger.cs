using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;

namespace Lesson9_Abstraction_LoggerExample
{
    public class EmailLogger : Logger
    {
        public override void Delete(Guid id)
        {
            Log l = Search(id);
            logs.Remove(l);
        }

        public override void Log(Log log)
        {
            logs.Add(log);

            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress("your_email_address@gmail.com");
                mail.To.Add("yourownemailaddresswheretotestthis@gmail.com");
                mail.Subject = $"Log Email {log.Date.ToString("dd/MM/yyyy HH:mm:ss")}";
                mail.Body = $"Message: {log.Message}, Date: {log.Date}, Type: {log.Type}, It happened: {log.WhereItHappened}";

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("your_email_address", "password");
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
            }
            catch (Exception ex)
            {
              
            }
        }

        public override void MarkAsReviewed(Guid id)
        {
            Log l = Search(id);
            if (l != null)
            {
                l.Reviewed = true;
            }
        }

        public override Log Search(Guid id)
        {
            foreach (Log item in logs)
            {
                if (item.Id == id)
                    return item;
            }

            return null;
        }

    }
}
