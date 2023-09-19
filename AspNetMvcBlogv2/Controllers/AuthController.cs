using AspNetMvcBlogv2.Data;
using AspNetMvcBlogv2.Data.DTOs;
using AspNetMvcBlogv2.Data.Entity;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Scaffolding.Metadata;
using System.Security.Claims;
using System.Text.Json;

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

      else
      {
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
    [HttpGet]
    public IActionResult Login(string? redirectUrl)
    {

      return View();
    }
    [HttpPost]
    public IActionResult Login(LoginUserDto model)
    {
      if (model == null)
      {
        return RedirectToAction(nameof(Login));
      }

      if (!ModelState.IsValid)
      {
        return View(model);
      }

      var user = appDbContext.User.FirstOrDefault(t => t.Email == model.Email && t.Password == model.Password);

      if (user == null)
      {
        ModelState.AddModelError(nameof(model.Password), "Kullanıcı kodu veya şifreniz hatalı");
        return View(model);
      }

      if (string.IsNullOrEmpty(HttpContext.Session.GetString("user")))
      {
        string userJson = JsonSerializer.Serialize<User>(user);
        HttpContext.Session.SetString("user", userJson);
        HttpContext.Session.SetInt32("isLoggedIn", 1);
      }

      #region claim
      var claims = new List<Claim>()
      {
        new Claim(ClaimTypes.Name, user.Name),
        new Claim(ClaimTypes.Surname, user.Surname),
        new Claim(ClaimTypes.Email, user.Email)

      };

      var claimsIdentity = new ClaimsIdentity(claims,
      CookieAuthenticationDefaults.AuthenticationScheme);

      #endregion

      return RedirectToAction(nameof(Index),"Home");

    }

    public IActionResult Logout()
    {
      HttpContext.Session.Clear();

      //HttpContext.Session.Remove("user");

    return Redirect("/"); ;

    }

    public IActionResult ForgotPassword()
    {
      return View();
    }
  }
}
