using AspNetMvcBlogv2.Persistence.Entity;

namespace AspNetMvcBlogv2.ViewModels
{
  public class PageCategoryViewModel
  {
  public IEnumerable<Category> Categories { get; set; }
  public IEnumerable<Page> Pages { get; set; }
  }
}
