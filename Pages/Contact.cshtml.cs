using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PersonalSite.Pages
{
    public class ContactModel : PageModel
    {
        public string ResumeEnding { get; set; }
        public void OnGet()
        {
            ResumeEnding = "document/d/1rgc5FIiAgqemODFY49gUDYPyXWuROmcwXFWccNp04e4/edit?usp=sharing";
        }
    }
}
