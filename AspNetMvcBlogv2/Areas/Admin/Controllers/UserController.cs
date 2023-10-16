using AspNetMvcBlogv2.Business.Dtos.PageDtos;
using AspNetMvcBlogv2.Business.Dtos.UserDtos;
using AspNetMvcBlogv2.Business.Services.Abstract;
using AspNetMvcBlogv2.Persistence.Entity;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace AspNetMvcBlogv2.Areas.Admin.Controllers
{
  [Area("Admin")]
  public class UserController : Controller
  {
    private readonly IUserService _userService;
    private readonly IMapper _mapper;
    public UserController(IUserService userService, IMapper mapper)
    {
      _userService = userService;
      _mapper = mapper;
    }
    [HttpGet]
    public async Task<IActionResult> Index()
    {
      var users = await _userService.GetAllAsync();
      var usersDtos = _mapper.Map<List<UserDto>>(users);
      return View(usersDtos);
    }

    [HttpGet]
    public async Task<IActionResult> Edit(Guid id)
    {
      var user = await _userService.GetByIdAsync(id);
      var userDto = _mapper.Map<CreateOrEditUserDto>(user);
      return View(userDto);
    }
    [HttpPost]
    public async Task<IActionResult> Edit(CreateOrEditUserDto createOrEditUserDto)
    {
      var user = _mapper.Map<User>(createOrEditUserDto);
      await _userService.UpdateAsync(user);
      return RedirectToAction("Index", "User", new { area = "Admin" });
    }

    [HttpPost]
    public async Task<IActionResult> Remove(Guid id)
    {

      await _userService.DeleteByIdAsync(id);

      return RedirectToAction("Index", "User", new { area = "Admin" });
    }

    [HttpGet]
    public async Task<IActionResult> Add()
    {
      return View();
    }

    [HttpPost]
    public async Task<IActionResult> Add(CreateOrEditUserDto createOrEditUserDto)
    {
      var user = _mapper.Map<User>(createOrEditUserDto);
      await _userService.InsertAsync(user);
      return RedirectToAction("Index", "User", new { area = "Admin" });
    }
  }
}

