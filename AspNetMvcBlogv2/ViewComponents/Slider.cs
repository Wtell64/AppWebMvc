using AspNetMvcBlogv2.Persistence.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AspNetMvcBlogv2.ViewComponents
{

  public class Slider : ViewComponent
  {
    private readonly AppDbContext _context;
    public Slider(AppDbContext appDbContext)
    {

      _context = appDbContext;
    }
    public IViewComponentResult Invoke()
    {
      var posts = _context.Post.Include(x => x.Images).Include(x => x.CategoryPosts).ThenInclude(cp => cp.Category).ToList();
      return View(posts);
    }

  }


}
