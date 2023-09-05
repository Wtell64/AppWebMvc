using AspNetMvcBlogv2.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AspNetMvcBlogv2.Controllers
{
	public class CategoryController : Controller
	{
		private readonly AppDbContext appDbContext;

		public CategoryController(AppDbContext appDbContext)
		{
			this.appDbContext = appDbContext;
		}

		public IActionResult Index(Guid id) //, int? page ne icin bilmiyorum sonra eklerim
		{
			var category = appDbContext.Category.SingleOrDefault(c => c.Id == id);

			if (category == null)
			{
				return NotFound();
			}

			ViewBag.Title = category.Name;

			var posts = appDbContext.Post
				.Where(p => p.CategoryPosts.Any(cp => cp.CategoryId == id))
				.Include(p => p.Images) // Include the related PostImages
				.ToList();

			return View(posts);

		}
	}
}
