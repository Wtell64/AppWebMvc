using AspNetMvcBlogv2.Business.Dtos.CategoryDtos;
using AspNetMvcBlogv2.Business.Services.Abstract;
using AspNetMvcBlogv2.Persistence.Entity;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace AspNetMvcBlogv2.Areas.Admin.Controllers
{
  [Area("Admin")]
  public class CategoryController : Controller
  {
    private readonly ICategoryService _categoryService;
    private readonly IMapper _mapper;
    public CategoryController(ICategoryService categoryService, IMapper mapper)
    {
      _categoryService = categoryService;
      _mapper = mapper;
    }
    [HttpGet]
    public async Task<IActionResult> Index()
    {
      var catagories = await _categoryService.GetAllAsync();
      var categoriesDtos = _mapper.Map<List<CategoryDto>>(catagories);
      return View(categoriesDtos);
    }

    [HttpGet]
    public async Task<IActionResult> Edit(Guid id)
    {
      var category = await _categoryService.GetByIdAsync(id);
      var categoryDto = _mapper.Map<CreateOrEditCategoryDto>(category);
      return View(categoryDto);
    }
    [HttpPost]
    public async Task<IActionResult> Edit(CreateOrEditCategoryDto createOrEditCategoryDto)
    {
      var category = _mapper.Map<Category>(createOrEditCategoryDto);
      await _categoryService.UpdateAsync(category);
      return RedirectToAction("Index", "Category", new { area = "Admin" });
    }

    [HttpPost]
    public async Task<IActionResult> Remove(Guid id)
    {

      await _categoryService.DeleteByIdAsync(id);

      return RedirectToAction("Index", "Category", new { area = "Admin" });
    }

    [HttpGet]
    public async Task<IActionResult> Add()
    {

      return View();
    }

    [HttpPost]
    public async Task<IActionResult> Add(CreateOrEditCategoryDto createOrEditCategoryDto)
    {
      var category = _mapper.Map<Category>(createOrEditCategoryDto);
      await _categoryService.InsertAsync(category);
      return RedirectToAction("Index", "Category", new { area = "Admin" });
    }





  }
}
