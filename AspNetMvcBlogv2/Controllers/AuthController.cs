using AspNetMvcBlogv2.Data;
using AspNetMvcBlogv2.Data.DTOs;
using AspNetMvcBlogv2.Data.Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Scaffolding.Metadata;

namespace AspNetMvcBlogv2.Controllers
{
  public class AuthController : Controller
  {
    private readonly AppDbContext appDbContext;

    public AuthController(AppDbContext appDbContext)
    {
      this.appDbContext = appDbContext;
    }

    public IActionResult Register()
    {
      return View();
    }
    [HttpPost]
    public IActionResult Register(RegisterUserDto model)
    {
      if (!ModelState.IsValid)
      {
        RedirectToAction(nameof(Register), new { model });
      }

      if (model == null)
      {
        RedirectToAction(nameof(Index), "Home");
      }

      bool alreadyRegistered = appDbContext.User.Any(user => user.Email == model.Email);

      if (alreadyRegistered)
      {
        ModelState.AddModelError("Email", "Boyle bir email adresi zaten mevcut");

        ViewBag.RegisterationMessage = "Kayit basarisiz oldu";
        RedirectToAction(nameof(Register));
      }

      else {
        var dataModel = new User()
        {
          Id = Guid.NewGuid(),
          Email = model.Email,
          Name = model.Name,
          Surname = model.Surname,
          Password = model.Password,
          ProfilePictureURL = model.ProfilePictureURL

        };

        appDbContext.Add(dataModel);
        appDbContext.SaveChanges();
        ViewBag.RegisterationMessage = "Kayit basari ile gerceklestirildi";
        return View();
      }
      return View();

    }
    public IActionResult Login(string? redirectUrl)
    {
      return View();
    }
    public IActionResult ForgotPassword()
    {
      return View();
    }
  }
}
