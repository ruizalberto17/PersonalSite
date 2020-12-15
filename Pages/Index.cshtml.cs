using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalSite.Pages
{
	public class IndexModel : PageModel
	{
		public string FullName { get; set; }
		public string LinkedInUsername { get; set; }
		public int YearsOfExperience { get; set; }
		public List<string> Languages { get; set; }
		public void OnGet()
		{
			FullName = "Alberto Ruiz";
			LinkedInUsername = "albertoruiz17";
			YearsOfExperience = 2;
			Languages = new List<string> {
				"C#",
				"Javascript",
				"Java",
				"Python",
				"C/C++",
				"HTML",
				"CSS",
				"ASP.NET"
			};
		}
	}
}
