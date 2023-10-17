using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AspNetMvcBlogv2.Persistence.Entity;
namespace AspNetMvcBlogv2.Business.Services.Abstract
{
	public interface IPostService
	{
		Task DeleteByIdAsync(Guid id);
		Task<IEnumerable<Post>> GetAllAsync();
		Task<Post> GetByIdAsync(Guid id);

    Task<Post> GetByIdAsyncWithImages(Guid id);


    Task InsertAsync(Post post);
		Task UpdateAsync(Post post);

		Task<PostImage> GetPostImageByIdAsync(Guid postId);

		Task InsertPostImageAsync(PostImage postImage);

    Task UpdatePostImageAsync(PostImage postImage);

    Task DeletePostImageByIdAsync(Guid id);

    Task<Post> GetByIdAsyncAllComments(Guid id);

    Task<PostComment> GetPostCommentByIdAsync(Guid postId);

    Task InsertPostCommentAsync(PostComment postComment);

    Task UpdatePostCommentAsync(PostComment postComment);

    Task DeletePostCommentByIdAsync(Guid id);


  }
}
