using AspNetMvcBlogv2.Business.Services.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AspNetMvcBlogv2.Persistence.Entity;
using AspNetMvcBlogv2.Persistence.Context;

namespace AspNetMvcBlogv2.Business.Services.Concrete
{
  public class PostService : IPostService

  {

    private readonly AppDbContext _context;

    public PostService(AppDbContext dbContext)
    {
      _context = dbContext;
    }

    public async Task DeleteByIdAsync(Guid id)
    {

      Post entityToDelete = await _context.Set<Post>().FindAsync(id);
      if (entityToDelete != null)
      {
        _context.Set<Post>().Remove(entityToDelete);
        await _context.SaveChangesAsync();
      }
    }

    public async Task DeletePostCommentByIdAsync(Guid id)
    {
      PostComment entityToDelete = await _context.Set<PostComment>().FindAsync(id);
      if (entityToDelete != null)
      {
        _context.Set<PostComment>().Remove(entityToDelete);
        await _context.SaveChangesAsync();
      }
    }

    public async Task DeletePostImageByIdAsync(Guid id)
    {
      PostImage entityToDelete = await _context.Set<PostImage>().FindAsync(id);
      if (entityToDelete != null)
      {
        _context.Set<PostImage>().Remove(entityToDelete);
        await _context.SaveChangesAsync();
      }
    }

    public async Task<IEnumerable<Post>> GetAllAsync()
    {

      return await _context.Set<Post>().ToListAsync();
    }

    public async Task<Post> GetByIdAsync(Guid id)
    {

      return await _context.Set<Post>().FindAsync(id);
    }

    public async Task<Post> GetByIdAsyncAllComments(Guid id)
    {
      return await _context.Set<Post>()
    .Include(p => p.Comments)
    .Where(p => p.Id == id)
    .FirstOrDefaultAsync();
    }

    public async Task<Post> GetByIdAsyncWithImages(Guid id)
    {
      return await _context.Set<Post>()
          .Include(p => p.Images)
          .Where(p => p.Id == id)
          .FirstOrDefaultAsync();
    }

    public async Task<PostComment> GetPostCommentByIdAsync(Guid postId)
    {
      return await _context.Set<PostComment>().FindAsync(postId);
    }

    public async Task<PostImage> GetPostImageByIdAsync(Guid postId)
    {
      return await _context.Set<PostImage>().FindAsync(postId);
    }

    public async Task InsertAsync(Post post)
    {

      await _context.Set<Post>().AddAsync(post);
      await _context.SaveChangesAsync();
    }

    public async Task InsertPostCommentAsync(PostComment postComment)
    {
      await _context.Set<PostComment>().AddAsync(postComment);
      await _context.SaveChangesAsync();
    }

    public async Task InsertPostImageAsync(PostImage postImage)
    {
      await _context.Set<PostImage>().AddAsync(postImage);
      await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(Post post)
    {

      _context.Update(post);
      await _context.SaveChangesAsync();
    }

    public async Task UpdatePostCommentAsync(PostComment postComment)
    {
      _context.Update(postComment);
      await _context.SaveChangesAsync();
    }

    public async Task UpdatePostImageAsync(PostImage postImage)
    {
      _context.Update(postImage);
      await _context.SaveChangesAsync();
    }
  }
}
