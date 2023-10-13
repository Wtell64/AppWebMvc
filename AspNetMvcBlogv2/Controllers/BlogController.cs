using AspNetMvcBlogv2.Persistence.Context;
using AspNetMvcBlogv2.Persistence.Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using System;

namespace AspNetMvcBlogv2.Controllers
{
  public class BlogController : Controller
  {
    private readonly AppDbContext appDbContext;
    
    public BlogController(AppDbContext appDbContext) 
    {
			this.appDbContext = appDbContext;
    }

    public IActionResult Search(string searchTerm, int page = 1) //, int? page
    {

      ViewBag.SearchTerm = searchTerm;

			var totalPostCount = appDbContext.Post.Count();
			var postCountPerPage = 10;
			var pageCount = Math.Ceiling((double)totalPostCount / postCountPerPage);
			if (page <= 0) page = 1;
			if (page > pageCount) page = (int)pageCount;

			ViewBag.PageCount = pageCount;


			var relatedPosts = appDbContext.Post.Where(p => p.Title.Contains(searchTerm) || p.Content.Contains(searchTerm))
			.Skip((page - 1) * postCountPerPage).Take(postCountPerPage)
			.Include(x => x.CategoryPosts).ThenInclude(cp => cp.Category)
      .Include(p => p.Images).ToList();

      

      return View(relatedPosts);
    }

    public IActionResult Detail(Guid id)
		{

			var post = appDbContext.Post
		.Where(x => x.Id == id)
		.Include(x => x.Images)
		.Include(x => x.Comments)
				.ThenInclude(u => u.User).Include(x => x.CategoryPosts) 
        .ThenInclude(cp => cp.Category).FirstOrDefault();

			if (post == null) {
				return NotFound();
			}




      return View(post);
    }
  }
}
