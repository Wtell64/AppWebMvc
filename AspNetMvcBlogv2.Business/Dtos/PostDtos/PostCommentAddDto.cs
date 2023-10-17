using AspNetMvcBlogv2.Persistence.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetMvcBlogv2.Business.Dtos.PostDtos
{
  public class PostCommentAddDto
  {

    public Guid Id { get; set; }

    public string Content { get; set; }

    public Guid PostId { get; set; }

    public Guid UserId { get; set; }
  }
}
