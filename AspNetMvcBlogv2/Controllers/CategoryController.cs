using Microsoft.AspNetCore.Mvc;

namespace AspNetMvcBlogv2.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index(int? id, int? page)
        {
            return View();
        }
    }
}
