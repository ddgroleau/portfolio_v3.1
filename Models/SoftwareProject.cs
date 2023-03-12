using System.Runtime.InteropServices;

namespace portfolio_v3._1.Models
{
    public class SoftwareProject : PortfolioItem
    {
        public string SiteHref { get; private set; }
        public string RepositoryHref { get; private set; }
        public List<string> Technologies { get; private set; }

        private SoftwareProject(
            string imageHref, 
            string imageAlt, 
            string title, 
            string siteHref, 
            string repoHref, 
            List<string> technologies, 
            string description
            )
        {
            ImagePath = imageHref;
            ImageAlt = imageAlt;
            Title = title;
            SiteHref = siteHref;
            RepositoryHref = repoHref;
            Technologies = technologies;
            Description = description;
        }

        public static SoftwareProject Create(
            string imageHref,
            string imageAlt,
            string title,
            string siteHref,
            string repoHref,
            List<string> technologies,
            string description
            ) => new SoftwareProject(imageHref, imageAlt, title, siteHref, repoHref, technologies, description);
    }
}
