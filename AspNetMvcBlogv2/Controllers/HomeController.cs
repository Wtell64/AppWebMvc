using AspNetMvcBlogv2.Persistence.Context;
using AspNetMvcBlogv2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
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
		public IActionResult Index(int page = 1)
		{

			var totalPostCount = _context.Post.Count();
			var postCountPerPage = 10;
			var pageCount = Math.Ceiling((double)totalPostCount / postCountPerPage);
			if (page <= 0) page = 1;
			if (page > pageCount) page = (int)pageCount;

			ViewBag.PageCount = pageCount;

			var posts = _context.Post
			.Skip((page - 1) * postCountPerPage).Take(postCountPerPage)
			.Include(x => x.Images)
			.Include(x => x.CategoryPosts).ThenInclude(cp => cp.Category).ToList();




			return View(posts);
		}

		[HttpPost]
		public IActionResult Index(string searchTerm)
		{
			return RedirectToAction("Search", "Blog", new { area = "", searchTerm });
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