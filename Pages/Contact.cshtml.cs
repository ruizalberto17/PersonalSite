using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PersonalSite.Models;
using PersonalSite.Services;
using System;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace PersonalSite.Pages
{
    public class ContactModel : PageModel
    {
        public string ResumeEnding { get; set; }
        [BindProperty]
        public Email Email { get; set; }
        
        private readonly IMailService _mailSender;

        public ContactModel(IMailService mailSender)
        {
            _mailSender = mailSender;
        }

        public void OnGet()
        {
            ResumeEnding = "document/d/1rgc5FIiAgqemODFY49gUDYPyXWuROmcwXFWccNp04e4/edit?usp=sharing";
        }

        public async Task OnPost()
        {
            await _mailSender.Send(Email);
        }
        /*        public IActionResult OnPost()
                {
                    try
                    {
                        SmtpClient smtpClient = new SmtpClient("smtp.gmail.com")
                        {
                            Port = 587,
                            Credentials = new NetworkCredential("ruizalberto17@gmail.com", "juM463taj!"),
                            EnableSsl = true
                        };

                        MailMessage mailMessage = new MailMessage
                        {
                            From = new MailAddress("ruizalberto17@gmail.com"),
                            Subject = Email.Name + " - " + Email.Company + " - " + Email.PhoneNumber + " - " + Email.EmailAddress,
                            Body = Email.Body,
                            IsBodyHtml = false
                        };

                        mailMessage.To.Add("ruizalberto2510@gmail.com");
                        smtpClient.Send(mailMessage);

                        // Optionally, you can redirect to a success page
                        return RedirectToPage("/Index");
                    }
                    catch (Exception ex)
                    {
                        // Handle errors
                        ModelState.AddModelError(string.Empty, "Error: " + ex.Message);
                        return Page();
                    }
                }*/
        /*public async Task OnPost()
        {
            string toEmail = "ruizalberto2510@gmail.com";
            string subject = Email.Name + " - " + Email.Company + " - " + Email.PhoneNumber + " - " + Email.EmailAddress;
            string body = Email.Body;

            try
            {
                using (MailMessage mailMessage = new MailMessage())
                {
                    mailMessage.From = new MailAddress("ruizalberto17@gmail.com");
                    mailMessage.To.Add(toEmail);
                    mailMessage.Subject = subject;
                    mailMessage.Body = body;
                    mailMessage.IsBodyHtml = true;

                    SmtpClient smtpClient = new SmtpClient();
                    smtpClient.Send(mailMessage);

                    Response = "Email sent successfully!";
                }
            }
            catch (Exception ex)
            {
                lblMessage.Text = "Email sending failed. Error: " + ex.Message;
            }
        }*/

    }
}