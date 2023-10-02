using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AspNetMvcBlogv2.Persistence.Entity;

namespace AspNetMvcBlogv2.Business.Dtos.CategoryDtos
{
	public class CategoryDto
	{

		public Guid Id { get; set; }

		[Required]
		[StringLength(25, ErrorMessage = "{0} en fazla {1} harf olmali")]
		[MinLength(3, ErrorMessage = "{0} en az {1} harf olmali")]
		public string? Name { get; set; }

		//Relationship
		public ICollection<CategoryPost>? CategoryPosts { get; set; }
	}
}
