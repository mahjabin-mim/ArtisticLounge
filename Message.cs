using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace Gallery
{
    class Message
    {
        private static string fromMail = "artisticlounge07@gmail.com";
        private static string pass = "ArtisticLounge07";
        public string MsgCount { set; get; }
        public string Name { set; get; }
        public string Email { set; get; }
        public string User_Message { set; get; }

        public static bool SendPendingMail(String toMail)
        {
            try
            {
                MailMessage message = new MailMessage();
                SmtpClient smtp = new SmtpClient();

                message.From = new MailAddress(fromMail);
                message.To.Add(new MailAddress(toMail.Trim()));
                message.Subject = "Post a new art";
                message.Body = "Hello sir/madam,\nYour art is being reveiwed. You will be notified shortly when it is available on store.\nThanks.";

                smtp.Port = 587;
                smtp.Host = "smtp.gmail.com";
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential(fromMail, pass);
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Send(message);

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("err: " + ex.Message);
            }
            return false;
        }

        public static bool SendAcceptMail(String toMail)
        {
            try
            {
                MailMessage message = new MailMessage();
                SmtpClient smtp = new SmtpClient();

                message.From = new MailAddress(fromMail);
                message.To.Add(new MailAddress(toMail.Trim()));
                message.Subject = "Art posted.";
                message.Body = "Hello sir/madam,\nYour art is now live on store. \nThanks.";

                smtp.Port = 587;
                smtp.Host = "smtp.gmail.com";
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential(fromMail, pass);
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Send(message);

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("err: " + ex.Message);
            }
            return false;
        }

        public static bool SendDeclineMail(String toMail)
        {
            try
            {
                MailMessage message = new MailMessage();
                SmtpClient smtp = new SmtpClient();

                message.From = new MailAddress(fromMail);
                message.To.Add(new MailAddress(toMail.Trim()));
                message.Subject = "Art post Declined!";
                message.Body = "Dear sir/madam,\nWe are very sorry.\nFor some credential mismatch we declined your Art. \nThanks.";

                smtp.Port = 587;
                smtp.Host = "smtp.gmail.com";
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential(fromMail, pass);
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Send(message);

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("err: " + ex.Message);
            }
            return false;
        }
    }
}
