using AspNetMvcBlogv2.Controllers;
using AspNetMvcBlogv2.Data;
using AspNetMvcBlogv2.Data.Entity;
using AspNetMvcBlogv2.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace AspNetMvcBlogv2.ViewComponents
{

  public class Footer : ViewComponent
  {
		private readonly AppDbContext _context;
		public Footer( AppDbContext appDbContext)
		{

			_context = appDbContext;
		}
		public IViewComponentResult Invoke()
    {


      var pages = _context.Page.ToList();

      return View(pages); 
    }

  }


}
