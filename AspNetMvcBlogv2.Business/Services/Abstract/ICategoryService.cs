﻿using AspNetMvcBlogv2.Persistence.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetMvcBlogv2.Business.Services.Abstract
{
	public interface ICategoryService
	{
		Task DeleteByIdAsync(Guid id);
		Task<IEnumerable<Category>> GetAllAsync();
		Task<Category> GetByIdAsync(Guid id);
		Task InsertAsync(Category category);
		Task UpdateAsync(Category category);


	}
}
