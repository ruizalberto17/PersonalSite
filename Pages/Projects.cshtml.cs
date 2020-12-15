using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PersonalSite.Models;

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
					Title = "Earth Defender",
					Description = "A Unity based video game in which you fight against aliens to defend Earth. Built with Unity Framework and C#.",
					Year = 2018,
					Technologies = new List<string> {
						"Unity",
						"C#"
					}
				},
				new Project()
				{
					Title = "Personal Site",
					Description = "A personal website that presents viewers with information about myself, and personal projects. Built on ASP.NET Core Framework, using C#, Javascript, CSS, and HTML.",
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
					Title = "Spotivize",
					Description = "Spotivize is a music platform that uses geolocation to track when your favorite artists are playing in your local city! Built with Node, Express, React and MongoDB.",
					Year = 2016,
					Technologies = new List<string> {
						"Express",
						"React",
						"MongoDB"
					}
				}
			};
		}
	}
}
