﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AspNetMvcBlogv2.Persistence.Entity;
namespace AspNetMvcBlogv2.Business.Services.Abstract
{
	public interface IPostService
	{
		Task DeleteByIdAsync(int id);
		Task<IEnumerable<Post>> GetAllAsync();
		Task<Post> GetByIdAsync(int id);
		Task InsertAsync(Post post);
		Task UpdateAsync(Post post);

	}
}
