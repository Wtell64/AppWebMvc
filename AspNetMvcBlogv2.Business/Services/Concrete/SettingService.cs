using AspNetMvcBlogv2.Business.Services.Abstract;
using AspNetMvcBlogv2.Persistence.Context;
using AspNetMvcBlogv2.Persistence.Entity;
using Azure;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetMvcBlogv2.Business.Services.Concrete
{
	public class SettingService : ISettingService
	{

		private readonly AppDbContext _context;

		public SettingService(AppDbContext dbContext)
		{
			_context = dbContext;
		}
		public async Task DeleteByIdAsync(int id)
		{
			Setting entityToDelete = await _context.Set<Setting>().FindAsync(id);
			if (entityToDelete != null)
			{
				_context.Set<Setting>().Remove(entityToDelete);
				await _context.SaveChangesAsync();
			}
		}

		public async Task<IEnumerable<Setting>> GetAllAsync()
		{
			return await _context.Set<Setting>().ToListAsync();
		}

		public async Task<Setting> GetByIdAsync(int id)
		{
			return await _context.Set<Setting>().FindAsync(id);
		}

		public async Task InsertAsync(Setting setting)
		{
			await _context.Set<Setting>().AddAsync(setting);
			await _context.SaveChangesAsync();
		}

		public async Task UpdateAsync(Setting setting)
		{
			_context.Update(setting);
			await _context.SaveChangesAsync();
		}
	}
}
