using Microsoft.AspNetCore.Mvc.RazorPages;
using PersonalSite.Models;
using System.Collections.Generic;

namespace PersonalSite.Pages
{
    public class ProjectsModel : PageModel
    {

        public List<Project> Projects { get; set; }

        public string GithubUsername { get; set; }

        public void OnGet()
        {
            GithubUsername = "ruizalberto17";
            Projects = new List<Project> {
                new Project()
                {
                    Title = "National Park Biodiveristy Database",
                    Preview = "https://i.imgur.com/0LylhKg.png",
                    Description = "An application that allows analysis and visualization of National Park data. Built with Python using NumPy, SciPy, Pandas, and Matplotlib.",
                    Year = 2020,
                    Technologies = new List<string> {
                        "Python",
                        "NumPy",
                        "Pandas",
                        "Matplotlib",
                        "SciPy"
                    }
                },
                new Project()
                {
                    Title = "Personal Site",
                    Preview = "https://i.imgur.com/D40ZZsI.png",
                    Description = "A personal website that presents viewers with information about myself, and personal projects. Built on ASP.NET Core Framework, using C#, CSS, and HTML.",
                    Year = 2020,
                    Technologies = new List<string> {
                        "ASP.NET",
                        "C#",
                        "CSS",
                        "Javascript",
                        "HTML"
                    }
                },
                new Project()
                {
                    Title = "Stock Historical Data Web Scrapper",
                    Preview = "https://i.imgur.com/tsmdVNv.png",
                    Description = "A simper web scraper built using Python to retrieve and visualize the historical data of a company's stock during a specified time frame both selected by the user.",
                    Year = 2020,
                    Technologies = new List<string> {
                        "Python",
                        "BeautifulSoup",
                        "Pandas",
                        "Matplotlib"
                    }
                },
                new Project()
                {
                    Title = "Earth Defender",
                    Preview = "https://i.imgur.com/IhFiJMy.png",
                    Description = "A Unity based video game in which you fight against aliens to defend Earth. Built with Unity Framework and C#.",
                    Year = 2018,
                    Technologies = new List<string> {
                        "Unity",
                        "C#"
                    }
                }
            };
        }
    }
}
