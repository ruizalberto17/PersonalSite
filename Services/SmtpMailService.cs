using PersonalSite.Models;
using System.Net.Mail;
using System.Threading.Tasks;

namespace PersonalSite.Services
{
    public class SmtpMailService : IMailService
    {
        public async Task Send(Email email)
        {
            using (var smtp = new SmtpClient())
            {
                var msg = new MailMessage()
                {
                    Body = "Email Address: " + email.EmailAddress + "\n" + "Phone Number: " + email.PhoneNumber +
                    "\n\n" + email.Body,
                    Subject = email.Name + " from " + email.Company,
                    From = new MailAddress("ruza2031@gmail.com")
                };
                msg.To.Add("ruizalberto1017@gmail.com");
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new System.Net.NetworkCredential
                ("ruza2031", "");
                smtp.EnableSsl = true;
                await smtp.SendMailAsync(msg);
            }
        }

    }
}