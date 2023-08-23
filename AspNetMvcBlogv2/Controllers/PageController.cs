using Microsoft.AspNetCore.Mvc;

namespace AspNetMvcBlogv2.Controllers
{
    public class PageController : Controller
    {
        public IActionResult Detail(int? id)
        {
            return View();
        }
    }
}
