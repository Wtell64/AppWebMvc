using System.ComponentModel.DataAnnotations;

namespace AspNetMvcBlogv2.Data.DTOs
{
	public class RegisterUserDto
	{

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

		[Required(ErrorMessage = "{0} bos gecilemez")]
		[StringLength(100, ErrorMessage = "{0} en fazla {1} harf olmali")]
		public string ProfilePictureURL { get; set; }
	}
}
