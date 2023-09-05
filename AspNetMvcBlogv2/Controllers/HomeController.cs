using AspNetMvcBlogv2.Data;
using AspNetMvcBlogv2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace AspNetMvcBlogv2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly AppDbContext _context;
    public HomeController(ILogger<HomeController> logger, AppDbContext appDbContext)
        {
           _logger = logger;
          _context = appDbContext;
    }

        [HttpGet]
        public IActionResult Index()
        {
            var posts = _context.Post.Include(x => x.Images ).ToList();
            return View(posts);
        }

		    [HttpPost]
		    public IActionResult Index(string searchTerm)
		    {
			    return RedirectToAction("Search", "Blog", new { searchTerm });
		    }

		public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}