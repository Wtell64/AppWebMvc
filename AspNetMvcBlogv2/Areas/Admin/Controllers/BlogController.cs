using AspNetMvcBlogv2.Business.Dtos.PostDtos;
using AspNetMvcBlogv2.Business.Services.Abstract;
using AspNetMvcBlogv2.Persistence.Entity;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AspNetMvcBlogv2.Areas.Admin.Controllers
{
  [Area("Admin")]
  public class BlogController : Controller
  {
    private readonly IPostService _postService;
    private readonly IUserService _userService;
    private readonly IMapper _mapper;
    public BlogController(IPostService postService, IUserService userService, IMapper mapper)
    {
      _postService = postService;
      _userService = userService;
      _mapper = mapper;
    }
    [HttpGet]
    public async Task<IActionResult> Index()
    {
      var posts = await _postService.GetAllAsync();
      var postsDtos = _mapper.Map<List<PostDto>>(posts);
      return View(postsDtos);
    }

    [HttpGet]
    public async Task<IActionResult> Edit(Guid id)
    {
      
      var post = await _postService.GetByIdAsync(id);

      ViewBag.publishDate = post.PublishedAt.ToString("yyyy-MM-dd");
      ViewBag.updateDate = post.UpdatedAt.ToString("yyyy-MM-dd");

      var postDto = _mapper.Map<CreateOrEditPostDto>(post);

      return View(postDto);
    }
    [HttpPost]
    public async Task<IActionResult> Edit(CreateOrEditPostDto createOrEditPostDto)
    {
      
      var post = _mapper.Map<Post>(createOrEditPostDto);

      await _postService.UpdateAsync(post);
      return RedirectToAction("Index", "Blog", new { area = "Admin" });
    }

    [HttpPost]
    public async Task<IActionResult> Remove(Guid id)
    {

      await _postService.DeleteByIdAsync(id);

      return RedirectToAction("Index", "Blog", new { area = "Admin" });
    }

    [HttpGet]
    public async Task<IActionResult> Add()
    {

      return View();
    }

    [HttpPost]
    public async Task<IActionResult> Add(CreateOrEditPostDto createOrEditPostDto)
    {
      var post = _mapper.Map<Post>(createOrEditPostDto);

      post.PublishedAt = DateTime.Now;
      post.UpdatedAt = DateTime.Now;

      await _postService.InsertAsync(post);
      return RedirectToAction("Index", "Blog", new { area = "Admin" });
    }

    public async Task<IActionResult> ImageIndex(Guid id)
    {
      var post = await _postService.GetByIdAsyncWithImages(id);
     
      //var postt = 


      return View(post);
    }
    [HttpGet]

    public async Task<IActionResult> ImageAdd( Guid id)
    {
    //postimage servicede bulma yaz sayfaya yolla
      
      ViewBag.PostId = id;


      return View();
    }
    //input 
    [HttpPost]
    public async Task<IActionResult> ImageAdd(PostImageAddDto model)
    {


      var postImage = new PostImage{ PostId = model.PostId, Id = model.Id, ImageUrl = model.ImageUrl};

      _postService.InsertPostImageAsync(postImage);

      return RedirectToAction("ImageIndex", "Blog", new { area = "Admin", id = model.PostId });
      
    }




    [HttpGet]
    public async Task<IActionResult> ImageEdit(Guid id)
    {
      var postImage = await _postService.GetPostImageByIdAsync(id);

      ViewBag.PostId = id;

      return View(postImage);
    }
    [HttpPost]
    public async Task<IActionResult> ImageEdit(PostImageAddDto model)
    {


      var postImage = new PostImage { PostId = model.PostId, Id = model.Id, ImageUrl = model.ImageUrl };

      _postService.UpdatePostImageAsync(postImage);

      return RedirectToAction("ImageIndex", "Blog", new { area = "Admin", id = model.PostId });

    }










    [HttpPost]
    public async Task<IActionResult> ImageRemove(Guid id)
    {

      await _postService.DeletePostImageByIdAsync(id);

      return RedirectToAction("Index", "Blog", new { area = "Admin" });
    }

    public async Task<IActionResult> CommentIndex(Guid id)
    {
      var post = await _postService.GetByIdAsyncAllComments(id);

      //var postt = 


      return View(post);
    }
    [HttpGet]
    public async Task<IActionResult> CommentAdd(Guid id)
    {
      var post = await _postService.GetByIdAsync(id);

      var users = await _userService.GetAllAsync();

      var userList = new SelectList(users, "Id", "Email");
      ViewBag.UserList = userList;

      ViewBag.PostId = post.Id;


      return View();
    }

    [HttpPost]
    public async Task<IActionResult> CommentAdd(PostCommentAddDto model)
    {


      var postComment = new PostComment { PostId = model.PostId, Id = model.Id, Content = model.Content, UserId = model.UserId };

      _postService.InsertPostCommentAsync(postComment);

      return RedirectToAction("CommentIndex", "Blog", new { area = "Admin", id = model.PostId });

    }

    [HttpGet]
    public async Task<IActionResult> CommentEdit(Guid id)
    {
      var postComment = await _postService.GetPostCommentByIdAsync(id);

      ViewBag.PostId = id;
      return View(postComment);
    }

    [HttpPost]
    public async Task<IActionResult> CommentEdit(PostCommentAddDto model)
    {


      var postComment = new PostComment { PostId = model.PostId, Id = model.Id, Content = model.Content, UserId = model.UserId };

      _postService.UpdatePostCommentAsync(postComment);

      return RedirectToAction("CommentIndex", "Blog", new { area = "Admin", id = model.PostId });

    }

    [HttpPost]
    public async Task<IActionResult> CommentRemove(Guid id)
    {

      await _postService.DeletePostCommentByIdAsync(id);

      return RedirectToAction("Index", "Blog", new { area = "Admin" });
    }
  }
}
