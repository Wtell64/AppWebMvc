using AspNetMvcBlogv2.Data.Entity;

namespace AspNetMvcBlogv2.ViewModels
{
  public class PageCategoryViewModel
  {
  public IEnumerable<Category> Categories { get; set; }
  public IEnumerable<Page> Pages { get; set; }
  }
}
