using Microsoft.AspNetCore.Mvc;

namespace AspNetMvcBlogv2.Areas.Admin.Controllers
{
  [Area("Admin")]
  public class AuthController : Controller
  {
    public IActionResult Login()
    {
      return View();
    }

    public IActionResult Register()
    {
      return View();
    }
  }
}
