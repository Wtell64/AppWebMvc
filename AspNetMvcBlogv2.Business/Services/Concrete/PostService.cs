using AspNetMvcBlogv2.Business.Services.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AspNetMvcBlogv2.Persistence.Entity;

namespace AspNetMvcBlogv2.Business.Services.Concrete
{
	public class PostService : IPostService

	{

		private readonly DbContext _context;

		public PostService(DbContext dbContext){
			_context = dbContext;
		}

		public async Task DeleteByIdAsync(int id)
		{

			Post entityToDelete = await _context.Set<Post>().FindAsync(id);
			if (entityToDelete != null)
			{
				_context.Set<Post>().Remove(entityToDelete);
				await _context.SaveChangesAsync();
			}
		}

		public async Task<IEnumerable<Post>> GetAllAsync()
		{

			return await _context.Set<Post>().ToListAsync();
		}

		public async Task<Post> GetByIdAsync(int id)
		{

			return await _context.Set<Post>().FindAsync(id);
		}

		public async Task InsertAsync(Post post)
		{

			await _context.Set<Post>().AddAsync(post);
			await _context.SaveChangesAsync();
		}

		public async Task UpdateAsync(Post post)
		{

			_context.Update(post);
			await _context.SaveChangesAsync();
		}
	}
}
