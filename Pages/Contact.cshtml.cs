using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PersonalSite.Models;
using System.Collections.Generic;
using PersonalSite.Services;

namespace PersonalSite.Pages
{
    public class ContactModel : PageModel
    {
        public string ResumeEnding { get; set; }
        private readonly IMailService _mailSender;
        public ContactModel(IMailService mailSender)
        {
            _mailSender = mailSender;
        }
        [BindProperty]
        public Email Email { get; set; }
        
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