namespace HockeySajt.Services
{
    public class News
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public List<News> GetNews()
        {
            List<News> news = new List<News>(); 
            news.Add(new News() { Name = "Havre seriesegrare", Description = "Fc Havre tar SM-Guld för andra året i rad" });
            news.Add(new News() { Name = "Havre seriesegrare", Description = "Fc Havre tar SM-Guld för andra året i rad" });
            news.Add(new News() { Name = "Havre seriesegrare", Description = "Fc Havre tar SM-Guld för andra året i rad" });
            news.Add(new News() { Name = "Havre seriesegrare", Description = "Fc Havre tar SM-Guld för andra året i rad" });
            news.Add(new News() { Name = "Havre seriesegrare", Description = "Fc Havre tar SM-Guld för andra året i rad" });
            return news;
        }
    }
}
