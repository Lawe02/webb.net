using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HockeySajt.Pages
{
    public class RandomModel : PageModel
    {
        public int RandomNumber { get; set; }
        Random rnd = new Random();
        public string Time { get; set; }
        public void OnGet()
        {
            RandomNumber = rnd.Next(0,300000);
            Time = DateTime.Now.ToString("hh:mm");
        }
    }
}
