using Microsoft.AspNetCore.Mvc.RazorPages;
using portfolio_v3._1.Models;

namespace portfolio_v3._1.Pages
{
    public class WorkModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public List<SoftwareProject> Projects { get; private set; }
        public List<CommunityContribution> Contributions { get; private set; }

        public WorkModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }
        public void OnGet()
        {
            Projects = new()
            {
                SoftwareProject.Create(
                    "healthcare.svg",
                    "Healthcare Workers SVG",
                    "Health & Wellness Discount Storefront",
                    "https://www.whlchoices.com",
                    "",
                    new List<string> { "React", ".NET 6", "SCSS", "SQL/SQL Server", "Jest", "React Testing Library", "Cypress" },
                    ".NET REST API and React frontend for an Enterprise Business. Professional Project."
                ),
                SoftwareProject.Create(
                    "auth.svg",
                    "Secure Laptop",
                    "OAuth 2 Authorization Server",
                    "",
                    "https://github.com/ddgroleau/id-assert",
                    new List<string> {"Java", "SQL", "PostgreSQL", "Spring Boot", "Spring Security" },
                    "Spring Authorization Server implementing the OAuth 2.1 and OpenID Connect 1.0 specifications. Personal Project."
                ),
                SoftwareProject.Create(
                    "map.svg",
                    "Map SVG",
                    "Vendor Geolocator",
                    "https://portlandfinder.fullstackdan.com/",
                    "https://github.com/ddgroleau/PortlandFinder",
                    new List<string> {"C#", ".NET 7", "React", "Next.js", "Material UI" },
                    ".NET REST API and React frontend that displays vendor locations relative to the location of the user's device. Personal Project."
                ),
                SoftwareProject.Create(
                    "wordpress.svg",
                    "Website with WordPress Logo SVG",
                    "Enterprise Marketing Website",
                    "https://www.wholehealthliving.com",
                    "",
                    new List<string> {"WordPress","PHP", ".NET 6", "SCSS", "SQL", "MySQL & SQL Server", "JavaScript" },
                    ".NET REST API and WordPress frontend with custom theme/templates and dynamic healthcare provider search feature. Professional Project."
                ),
                SoftwareProject.Create(
                    "ecomm.svg",
                    "Shopping Bags SVG",
                    "Business Storefront",
                    "",
                    "https://github.com/ddgroleau/root-to-rise-api",
                    new List<string> {"Java", "Spring Boot", "SQL", "PostgreSQL", "React", "Next.js" },
                    "Java REST API and React frontend for a business marketing website and e-commerce storefront. Personal Project."
                ),
                SoftwareProject.Create(
                 "portfolio.svg",
                "Man sitting on desk",
                "This Portfolio Website",
                "https://fullstackdan.com/",
                "https://github.com/ddgroleau/portfolio_v3.1",
                new List<string> {"C#", "ASP.NET", "HTML/CSS" },
                "This portfolio website, built with ASP.NET Razor Pages. Personal Project."
                ),
                SoftwareProject.Create(
                    "server.svg",
                    "Server SVG",
                    "Linode Compute Instance",
                    "",
                    "",
                    new List<string> {"Bash","NGINX","Docker","Virtualization","Linux" },
                    "An Ubuntu virtual machine. I host websites, applications, and datastores using Docker and an NGINX reverse-proxy web server. Personal Project."
                )
            };
            Contributions = new()
            {
                CommunityContribution.Create(
                    "react-key-concepts.png",
                    "React Key Concepts Book Cover",
                    "\"React Key Concepts\" (Maximilian Schwarzmüller; Packt Publishing 2022)",
                    "https://www.packtpub.com/product/react-key-concepts/9781803234502",
                    "SEE BOOK",
                    "I reviewed the book as part of the Packt Reviewer's Club before the official book release and provided feedback to Packt Publishing."
                ),
                CommunityContribution.Create(
                    "csharp-workshop.png",
                    "C# Workshop Book Cover",
                    "\"The C# Workshop\" (Jason Hales, Almantas Karpavicius & Mateus Viegas; Packt Publishing 2022)",
                    "https://www.packtpub.com/product/the-c-workshop/9781800566491",
                    "SEE BOOK",
                    "I reviewed the book as part of the Packt Reviewer's Club before the official book release and provided feedback to Packt Publishing."
                ),
                CommunityContribution.Create(
                    "docker-for-devs.png",
                    "Docker for Developers Book Cover",
                    "\"Docker for Developers\" (Richard Bullington-McGuire, Andrew K. Dennis & Michael Schwartz; Packt Publishing 2020)",
                    "https://www.packtpub.com/product/react-key-concepts/9781803234502",
                    "SEE BOOK",
                    "I contributed to the GitHub repository for the book (github.com/PacktPublishing/Docker-for-Developers)."
                ),
            };
        }
    }
}
