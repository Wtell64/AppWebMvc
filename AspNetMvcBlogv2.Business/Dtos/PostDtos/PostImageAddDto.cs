using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetMvcBlogv2.Business.Dtos.PostDtos
{
  public class PostImageAddDto
  {
    public Guid Id { get; set; }

    public Guid PostId { get; set; }

    public string ImageUrl { get; set; }
  }
}
