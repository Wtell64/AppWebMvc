using AspNetMvcBlogv2.Business.Services.Abstract;
using AspNetMvcBlogv2.Persistence.Entity;
using Microsoft.EntityFrameworkCore;
using AspNetMvcBlogv2.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetMvcBlogv2.Business.Services.Concrete
{
	public class CategoryService : ICategoryService
	{
		private readonly AppDbContext _context;

		public CategoryService(AppDbContext dbContext)
		{
			_context = dbContext;
		}

		public async Task DeleteByIdAsync(Guid id)
		{
			Category entityToDelete = await _context.Set<Category>().FindAsync(id);
			if (entityToDelete != null)
			{
				_context.Set<Category>().Remove(entityToDelete);
				await _context.SaveChangesAsync();
			}
		}

		public async Task<IEnumerable<Category>> GetAllAsync()
		{
			return await _context.Set<Category>().ToListAsync();
		}

		public async Task<Category> GetByIdAsync(Guid id)
		{
			return await _context.Set<Category>().FindAsync(id);
		}

		public async Task InsertAsync(Category category)
		{
			await _context.Set<Category>().AddAsync(category);
			await _context.SaveChangesAsync();
		}

		public async Task UpdateAsync(Category category)
		{
			_context.Update(category);
			await _context.SaveChangesAsync();
		}
	}
}
