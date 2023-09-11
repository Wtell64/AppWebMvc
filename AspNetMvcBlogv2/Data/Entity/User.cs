﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AspNetMvcBlogv2.Data.Entity
{
	public class User
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public Guid Id { get; set; }

		[Required(ErrorMessage = "{0} bos gecilemez")]
		[StringLength(30, ErrorMessage = "{0} en fazla {1} harf olmali")]
		[MinLength(3, ErrorMessage = "{0} en az {1} harf olmali")]
		public string Name { get; set; }

		[Required(ErrorMessage = "{0} bos gecilemez")]
		[StringLength(30, ErrorMessage = "{0} en fazla {1} harf olmali")]
		[MinLength(3, ErrorMessage = "{0} en az {1} harf olmali")]
		public string Surname { get; set; }

		[Required(ErrorMessage = "{0} bos gecilemez")]
		[EmailAddress]
		[StringLength(30, ErrorMessage = "{0} en fazla {1} harf olmali")]
		[MinLength(3, ErrorMessage = "{0} en az {1} harf olmali")]
		public string Email { get; set; }

		[StringLength(30, ErrorMessage = "{0} en fazla {1} harf olmali")]
		[Required(ErrorMessage = "{0} bos gecilemez")]
		public string Password { get; set; }

		[StringLength(100, ErrorMessage = "{0} en fazla {1} harf olmali")]
		[Required(ErrorMessage = "{0} bos gecilemez")]
		public string ProfilePictureURL { get; set; }

	}
}
