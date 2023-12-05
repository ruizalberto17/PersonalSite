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
    }
}