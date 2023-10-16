using AspNetMvcBlogv2.Persistence.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetMvcBlogv2.Business.Services.Abstract
{
	public interface IPageService
	{
		Task DeleteByIdAsync(Guid id);
		Task<IEnumerable<Page>> GetAllAsync();
		Task<Page> GetByIdAsync(Guid id);
		Task InsertAsync(Page page);
		Task UpdateAsync(Page page);
	}
}
