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
            FullName = "Alberto Andres Ruiz";
            LinkedInUsername = "albertoruiz17";
            YearsOfExperience = 4;
            Languages = new List<string> {
                "Java",
                "JavaScript",
                "Python",
                "SQL",
                "C#",
            };
            Technologies = new List<string> {
                "Spring Boot",
                "Jira",
                "OpenShift",
                "Confluent Kafka",
                "Github/Bitbucket",
                "JUnit",
                "Wildfly/Tomcat",
                "Maven/Gradle",
                "MySQL",
                "ASP.NET",
            };
        }
    }
}
