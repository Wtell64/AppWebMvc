﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;

namespace AspNetMvcBlogv2.Persistence.Entity
{
	public class Page
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public Guid Id { get; set; }

		[Required]
		[StringLength(30, ErrorMessage = "{0} en fazla {1} harf olmali")]
		[MinLength(5, ErrorMessage = "{0} en az {1} harf olmali")]
		public string Title { get; set; }

		[Required]
		[StringLength(1500, ErrorMessage = "{0} en fazla {1} harf olmali")]
		[MinLength(3, ErrorMessage = "{0} en az {1} harf olmali")]
		public string Content { get; set; }


	}
}
