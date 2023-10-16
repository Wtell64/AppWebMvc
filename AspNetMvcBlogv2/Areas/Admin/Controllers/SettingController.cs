using AspNetMvcBlogv2.Business.Dtos.PageDtos;
using AspNetMvcBlogv2.Business.Dtos.SettingDtos;
using AspNetMvcBlogv2.Business.Services.Abstract;
using AspNetMvcBlogv2.Business.Services.Concrete;
using AspNetMvcBlogv2.Persistence.Entity;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace AspNetMvcBlogv2.Areas.Admin.Controllers
{
  [Area("Admin")]
  public class SettingController : Controller
  {
    private readonly ISettingService _settingService;
    private readonly IMapper _mapper;
    public SettingController(ISettingService settingService, IMapper mapper)
    {
      _settingService = settingService;
      _mapper = mapper;
    }
    [HttpGet]
    public async Task<IActionResult> Index()
    {
      var settings = await _settingService.GetAllAsync();
      var settingsDtos = _mapper.Map<List<SettingDto>>(settings);
      return View(settingsDtos);
    }

    [HttpGet]
    public async Task<IActionResult> Edit(Guid id)
    {
      var setting = await _settingService.GetByIdAsync(id);
      var settingDto = _mapper.Map<CreateOrEditSettingDto>(setting);
      return View(settingDto);
    }
    [HttpPost]
    public async Task<IActionResult> Edit(CreateOrEditSettingDto createOrEditSettingDto)
    {
      var setting = _mapper.Map<Setting>(createOrEditSettingDto);
      await _settingService.UpdateAsync(setting);
      return RedirectToAction("Index", "Setting", new { area = "Admin" });
    }

    [HttpPost]
    public async Task<IActionResult> Remove(Guid id)
    {

      await _settingService.DeleteByIdAsync(id);

      return RedirectToAction("Index", "Setting", new { area = "Admin" });
    }

    [HttpGet]
    public async Task<IActionResult> Add()
    {

      return View();
    }

    [HttpPost]
    public async Task<IActionResult> Add(CreateOrEditSettingDto createOrEditSettingDto)
    {
      var setting = _mapper.Map<Setting>(createOrEditSettingDto);
      await _settingService.InsertAsync(setting);
      return RedirectToAction("Index", "Setting", new { area = "Admin" });
    }
  }
}
