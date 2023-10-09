using Microsoft.EntityFrameworkCore;
using AspNetMvcBlogv2.Business.Services;
using AspNetMvcBlogv2.Business.Services.Concrete;
using AspNetMvcBlogv2.Business.Services.Abstract;
using AspNetMvcBlogv2.Business.AutoMapper;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<AspNetMvcBlogv2.Persistence.Context.AppDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DBConStr"));
});


builder.Services.AddSession(options =>
{
  options.Cookie.Name = ".Genel.Session";
  options.IdleTimeout = TimeSpan.FromSeconds(120);
  options.Cookie.HttpOnly = true; //cookies are accessed only by http and not via js
  options.Cookie.IsEssential = true; //says that cookies are essention for app to work
  //so if you have many cookies these are not optional
}
);
builder.Services.AddHttpContextAccessor();

builder.Services.AddScoped<IPostService, PostService>();
builder.Services.AddScoped<IPageService, PageService>();
builder.Services.AddScoped<ICategoryService, CategoryService>();
builder.Services.AddScoped<ISettingService, SettingService>();
builder.Services.AddScoped<IUserService, UserService>();

builder.Services.AddAutoMapper(typeof(MappingProfile));


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();


app.UseSession();
app.UseRouting();

app.UseAuthorization();

//app.MapControllerRoute(
//    name: "default",
//    pattern: "{controller=Home}/{action=Index}/{id?}");

app.UseEndpoints(endpoints =>
{
  endpoints.MapControllerRoute(
      name: "admin",
      pattern: "admin/{controller=Home}/{action=Index}/{id?}",
      defaults: new { area = "Admin" }
  );
  endpoints.MapControllerRoute(
      name: "default",
      pattern: "{controller=Home}/{action=Index}/{id?}"
  );
});


app.Run();
