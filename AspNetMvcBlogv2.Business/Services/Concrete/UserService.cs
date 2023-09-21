using AspNetMvcBlogv2.Business.Services.Abstract;
using AspNetMvcBlogv2.Persistence.Context;
using AspNetMvcBlogv2.Persistence.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AspNetMvcBlogv2.Business.Services.Concrete
{
	public class UserService : IUserService
	{
		private readonly AppDbContext _context;

		public UserService(AppDbContext dbContext)
		{
			_context = dbContext;
		}

		public async Task DeleteByIdAsync(int id)
		{
			User entityToDelete = await _context.Set<User>().FindAsync(id);
			if (entityToDelete != null)
			{
				_context.Set<User>().Remove(entityToDelete);
				await _context.SaveChangesAsync();
			}
		}

		public async Task<IEnumerable<User>> GetAllAsync()
		{
			return await _context.Set<User>().ToListAsync();
		}

		public async Task<User> GetByIdAsync(int id)
		{
			return await _context.Set<User>().FindAsync(id);
		}

		public async Task InsertAsync(User user)
		{
			await _context.Set<User>().AddAsync(user);
			await _context.SaveChangesAsync();
		}

		public async Task UpdateAsync(User user)
		{
			_context.Update(user);
			await _context.SaveChangesAsync();
		}
	}
}
