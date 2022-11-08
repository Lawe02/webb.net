using Microsoft.AspNetCore.Mvc;
using HockeySajt.Services;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HockeySajt.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public List<HockeyPlayer> Player { get; set; }  
        public DateTime Nu { get; set; }
        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            var service = new Class1();
            Player = service.HockeyPlayers();
            Nu = DateTime.Now;
        }
    }
}