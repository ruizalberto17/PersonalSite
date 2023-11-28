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
                    Title = "Software Engineer II",
                    Description = "Planned and Oversaw Sprints including and not limited to Jira ticketing,  documentation, and STIG Checklists architecture requirements. " +
                    "Optimized Project’s architecture by implementing SpringBoot Technologies requiring only one micro-service instead of two. " +
                    "Docker containerization and package management. " +
                    "Implemented custom error-handling and 75% test code coverage. " +
                    "Implemented peer code-reviews when updating code. " +
                    "Updating documentation and versioning.",
                    Date = "September 2022 - July 2023"
                },
                new Job()
                {
                    Company = "Forward Slope Inc.",
                    Title = "Software Engineer I",
                    Description = "Developed REST and SOAP APIs that handled critical translations between two micro-services. " +
                    "Integrated Confluent Kafka technologies into the microservices to prevent data loss and ensure data is properly translated. " +
                    "Designed CI/CD strategies for automating deployments to Openshift Clusters via Gitlab pipelines. Staging OpenShift environments for non - master branches. " +
                    "Production OpenShift environments when merging to master branch. " +
                    "Designed and Optimized XSDs to ensure uniform data for proper translation of request data while validating both requests and responses.",
                    Date = "March 2021 - September 2022"
                },
                new Job() 
                {
                    Company = "Forward Slope Inc.",
                    Title = "Jr. Software Engineer",
                    Description = "Developed and maintained Java, JavaScript, and Python code while collaborating with teams  following Agile Software Development methodologies. " +
                    "Implemented Continuous Integration technologies and procedures into newly developing  projects by creating and optimizing Jenkins server builds. " +
                    "Incorporated Test Automation through Jenkins, by incorporating JUnit Test checks within Maven/Gradle project builds. " +
                    "Optimized project architecture by removing unnecessary build dependencies leading to lower coupling between project modules and higher cohesion for modules.",
                    Date = "May 2019 - June 2020"
                },
                new Job()
                {
                    Company = "San Diego State University",
                    Title = "Undergraduate Research Assistant",
                    Description = "Designed a Relational Database using SQL for quick retrieval of Phage research. " +
                    "Optimized and maintained the database through Normalization database techniques to  remove and avoid redundancy. " +
                    "Created a dynamic website and User-Interface linked to the database using HTML, CSS, and JavaScript. " +
                    "Utilized PHP and MySQL in order to access and modify the database through the website depending on user privileges.",
                    Date = "May 2016 - Aug 2016"
                }
            };
        }
    }
}
