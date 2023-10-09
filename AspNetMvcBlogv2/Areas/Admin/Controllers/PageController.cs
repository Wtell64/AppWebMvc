using Microsoft.AspNetCore.Mvc;

namespace AspNetMvcBlogv2.Areas.Admin.Controllers
{
  [Area("Admin")]
  public class PageController : Controller
  {
    public IActionResult Index()
    {
      return View();
    }
  }
}
