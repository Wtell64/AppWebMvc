using AspNetMvcBlogv2.Controllers;
using AspNetMvcBlogv2.Data;
using Microsoft.AspNetCore.Mvc;

namespace AspNetMvcBlogv2.ViewComponents
{

  public class Navbar : ViewComponent
  {
		private readonly AppDbContext _context;
		public Navbar( AppDbContext appDbContext)
		{

			_context = appDbContext;
		}
		public IViewComponentResult Invoke()
    {
      var categories = _context.Category.ToList();
      return View(categories); 
    }

  }


}
