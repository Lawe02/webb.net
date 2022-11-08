using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HockeySajt.Pages
{
    public class myPageModel : PageModel
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public void OnGet()
        {
            Name = "Kalle";
            Age = 37;
        }
    }
}
