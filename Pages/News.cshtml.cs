using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HockeySajt.Services;

namespace HockeySajt.Pages
{
    public class NewsModel : PageModel
    {
        public List<News> list = new List<News>();
        News n = new News();
        public void OnGet()
        {
            list = n.GetNews();
        }
    }
}
