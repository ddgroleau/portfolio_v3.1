namespace portfolio_v3._1.Models
{
    public abstract class PortfolioItem
    {
        public string ImagePath { get; set; }
        public string ImageAlt { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
