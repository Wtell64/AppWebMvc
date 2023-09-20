using AspNetMvcBlogv2.Persistence.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetMvcBlogv2.Business.Services.Abstract
{
	public interface IUserService
	{
		Task DeleteByIdAsync(int id);
		Task<IEnumerable<User>> GetAllAsync();
		Task<User> GetByIdAsync(int id);
		Task InsertAsync(User user);
		Task UpdateAsync(User user);
	}
}
