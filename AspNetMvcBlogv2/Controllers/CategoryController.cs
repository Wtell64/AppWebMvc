using AspNetMvcBlogv2.Persistence.Context;
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

		public IActionResult Index(Guid id, int page = 1) //, int? page ne icin bilmiyorum sonra eklerim
		{
			

			
			var category = appDbContext.Category.SingleOrDefault(c => c.Id == id);

			if (category == null)
			{
				return NotFound();
			}

			ViewBag.Title = category.Name;

			var totalPostCount = appDbContext.Post.Count();
			var postCountPerPage = 10;
			var pageCount = Math.Ceiling((double)totalPostCount / postCountPerPage);
			if (page <= 0) page = 1;
			if (page > pageCount) page = (int)pageCount;

			ViewBag.PageCount = pageCount;

			var posts = appDbContext.Post
				.Where(p => p.CategoryPosts.Any(cp => cp.CategoryId == id))
				.Skip((page - 1) * postCountPerPage)
				.Take(postCountPerPage)
				.Include(p => p.Images).Include(x => x.CategoryPosts)
				.ThenInclude(cp => cp.Category)
				.ToList();

			return View(posts);

		}
	}
}
