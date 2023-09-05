using AspNetMvcBlogv2.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
    public IActionResult Search(string searchTerm) //, int? page
    {

      ViewBag.SearchTerm = searchTerm;

      var relatedPosts = appDbContext.Post.Where(p => p.Title.Contains(searchTerm) || p.Content.Contains(searchTerm) ).Include(p => p.Images).ToList();

      

      return View(relatedPosts);
    }

    public IActionResult Detail(Guid id)
		{

			var post = appDbContext.Post.Where(x => x.Id == id).Include(x => x.Images).Include(x => x.Comments).FirstOrDefault();

      if(post == null) {
        return NotFound();
      }

			return View(post);
    }
  }
}
