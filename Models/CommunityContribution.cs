namespace portfolio_v3._1.Models
{
    public class CommunityContribution : PortfolioItem
    {
        public string LinkHref { get; private set; }
        public string LinkText { get; private set; }

        private CommunityContribution(
            string imageHref,
            string imageAlt,
            string title,
            string linkHref,
            string linkText,
            string description
        )
        {
            ImagePath = imageHref;
            ImageAlt = imageAlt;
            Title = title;
            LinkHref = linkHref;
            LinkText = linkText;
            Description = description;
        }

        public static CommunityContribution Create(
            string imageHref,
            string imageAlt,
            string title,
            string linkHref,
            string linkText,
            string description
            ) => new CommunityContribution(imageHref, imageAlt, title, linkHref, linkText, description);
    }
}
