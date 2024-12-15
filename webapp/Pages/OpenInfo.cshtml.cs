using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace webapp.Pages
{
    [Authorize]
    public class OpenInfoModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}
