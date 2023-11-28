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
                    Title = "Personal Site",
                    Github = "https://github.com/ruizalberto17/PersonalSite",
                    Preview = "https://i.imgur.com/D40ZZsI.png",
                    Description = "A personal website that presents viewers with information about myself, and personal projects. Built on ASP.NET Framework using C#.",
                    Year = 2023,
                    Technologies = new List<string> {
                        "ASP.NET",
                        "C#"
                    }
                },
                new Project()
                {
                    Title = "National Park Biodiveristy Database",
                    Github = "https://github.com/ruizalberto17/biodiversity_project",
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
                    Title = "Stock Historical Data Web Scrapper",
                    Github = "https://github.com/ruizalberto17/WebScraper",
                    Preview = "https://i.imgur.com/tsmdVNv.png",
                    Description = "A simple web scraper built using Python to retrieve and visualize the historical data of a company's stock during a specified time frame both selected by the user.",
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
                    Github = "https://github.com/ruizalberto17/EarthDefender",
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
