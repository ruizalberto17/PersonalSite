using Microsoft.AspNetCore.Mvc.RazorPages;
using PersonalSite.Models;
using System.Collections.Generic;

namespace PersonalSite.Pages
{
    public class ExperienceModel : PageModel
    {
        public List<Job> Jobs { get; set; }
        public void OnGet()
        {
            Jobs = new List<Job>() {
                new Job()
                {
                    Company = "Forward Slope Inc.",
                    Title = "Jr. Software Engineer",
                    Description = "Collaborated with teams of various sizes during all stages of the agile development lifecycle," +
                    " from requirement gathering to product releases. Wrote and optimized JUnit code, while also implementing Jenkins for" +
                    " consistent and thorough automated testing. Wrote, modified, and maintained Java code while providing, and updating documentation.",
                    Date = "May 2019 - June 2020"
                },
                new Job()
                {
                    Company = "San Diego State University",
                    Title = "Undergraduate Teaching Assistant",
                    Description = "Mentored students through office hours and one-on-one communication. Checked assignments, proctored tests, and provided grades according " +
                    "to university standards. Maintained atmosphere of academic learning and advancement to facilitate learning and development of critical thinking skills.",
                    Date = "Jan 2017 - May 2017"
                },
                new Job()
                {
                    Company = "Apple Inc.",
                    Title = "AppleCare College Advisor",
                    Description = "Efficient use of available resources while multi-tasking in order to solve problem at hand. Ability to quickly learn and apply new company " +
                    "policies and procedures to further help customers. Verified data integrity and accuracy.",
                    Date = "Aug 2016 - Feb 2017"
                },
                new Job()
                {
                    Company = "San Diego State University",
                    Title = "Undergraduate Research Assistant",
                    Description = "Designed, implemented and monitored website and database while continuously improving it in a fast-paced environment. " +
                    "Created site layout and user interface using HTML and CSS. Utilized PHP, SQL, and JavaScript and other languages as needed.",
                    Date = "May 2016 - Aug 2016"
                }
            };
        }
    }
}
