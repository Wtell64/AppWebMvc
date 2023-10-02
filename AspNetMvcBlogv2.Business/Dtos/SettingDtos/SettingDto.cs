﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetMvcBlogv2.Business.Dtos.SettingDtos
{
	public class SettingDto
    {
		public Guid Id { get; set; }


		[StringLength(50)]
		[MinLength(5)]
		public string? Name { get; set; }

		[Required]
		[MaxLength(255)]
		public string? Value { get; set; }
	}
}
