using AspNetMvcBlogv2.Controllers;
using AspNetMvcBlogv2.Persistence;
using AspNetMvcBlogv2.Persistence.Entity;
using AspNetMvcBlogv2.Persistence.Context;
using AspNetMvcBlogv2.ViewModels;
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

      var pages = _context.Page.ToList();

      var model = new PageCategoryViewModel { Categories = categories, Pages = pages };
      return View(model); 
    }

  }


}
