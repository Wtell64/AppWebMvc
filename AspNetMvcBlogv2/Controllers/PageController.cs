using AspNetMvcBlogv2.Data;
using Microsoft.AspNetCore.Mvc;

namespace AspNetMvcBlogv2.Controllers
{
    public class PageController : Controller
    {
		private readonly AppDbContext appDbContext;

		public PageController(AppDbContext appDbContext)
        {
			this.appDbContext = appDbContext;
		}

        public IActionResult Detail(Guid id)
        {
            var page = appDbContext.Page.Where(p => p.Id == id).FirstOrDefault();

            return View(page);
        }
    }
}
