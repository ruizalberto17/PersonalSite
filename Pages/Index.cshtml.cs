using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace PersonalSite.Pages
{
    public class IndexModel : PageModel
    {
        public string FullName { get; set; }
        public string LinkedInUsername { get; set; }
        public int YearsOfExperience { get; set; }
        public List<string> Languages { get; set; }
        public List<string> Technologies { get; set; }
        public void OnGet()
        {
            FullName = "Alberto Ruiz";
            LinkedInUsername = "albertoruiz17";
            YearsOfExperience = 2;
            Languages = new List<string> {
                "C#",
                "Java",
                "Python",
                "SQL",
                "JavaScript",
                "C/C++",
                "HTML",
                "CSS",
                "ASP.NET"
            };
            Technologies = new List<string> {
                "Jira",
                "Jenkins",
                "Github/Bitbucket",
                "JUnit",
                "Wildfly/Tomcat",
                "Maven/Gradle",
                "MySQL",
                "Azure"
            };
        }
    }
}
