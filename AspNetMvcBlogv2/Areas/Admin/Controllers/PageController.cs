using AspNetMvcBlogv2.Business.Dtos.CategoryDtos;
using AspNetMvcBlogv2.Business.Dtos.PageDtos;
using AspNetMvcBlogv2.Business.Services.Abstract;
using AspNetMvcBlogv2.Persistence.Entity;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace AspNetMvcBlogv2.Areas.Admin.Controllers
{
  [Area("Admin")]
  public class PageController : Controller
  {

    private readonly IPageService _pageService;
    private readonly IMapper _mapper;
    public PageController(IPageService pageService, IMapper mapper)
    {
      _pageService = pageService;
      _mapper = mapper;
    }
    [HttpGet]
    public async Task<IActionResult> Index()
    {
      var pages = await _pageService.GetAllAsync();
      var pagesDtos = _mapper.Map<List<PageDto>>(pages);
      return View(pagesDtos);
    }

    [HttpGet]
    public async Task<IActionResult> Edit(Guid id)
    {
      var page = await _pageService.GetByIdAsync(id);
      var pageDto = _mapper.Map<CreateOrEditPageDto>(page);
      return View(pageDto);
    }
    [HttpPost]
    public async Task<IActionResult> Edit(CreateOrEditPageDto createOrEditPageDto)
    {
      var page = _mapper.Map<Page>(createOrEditPageDto);
      await _pageService.UpdateAsync(page);
      return RedirectToAction("Index", "Page", new { area = "Admin" });
    }

    [HttpPost]
    public async Task<IActionResult> Remove(Guid id)
    {

      await _pageService.DeleteByIdAsync(id);

      return RedirectToAction("Index", "Page", new { area = "Admin" });
    }

    [HttpGet]
    public async Task<IActionResult> Add()
    {

      return View();
    }

    [HttpPost]
    public async Task<IActionResult> Add(CreateOrEditPageDto createOrEditPageDto)
    {
      var page = _mapper.Map<Page>(createOrEditPageDto);
      await _pageService.InsertAsync(page);
      return RedirectToAction("Index", "Page", new { area = "Admin" });
    }
  }
}
