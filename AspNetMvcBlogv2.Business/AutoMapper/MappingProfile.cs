using AspNetMvcBlogv2.Business.Dtos.CategoryDtos;
using AspNetMvcBlogv2.Business.Dtos.PageDtos;
using AspNetMvcBlogv2.Business.Dtos.PostDtos;
using AspNetMvcBlogv2.Business.Dtos.UserDtos;
using AspNetMvcBlogv2.Persistence.Entity;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetMvcBlogv2.Business.AutoMapper
{
	public class MappingProfile : Profile
	{
        public MappingProfile()
        {
			CreateMap<Category, CategoryDto>().ReverseMap();
			CreateMap<Category, ViewCategoryDto>().ReverseMap();
			CreateMap<Category, CreateOrEditCategoryDto>().ReverseMap();

			CreateMap<Post, CreateOrEditPostDto>().ReverseMap();
			CreateMap<Post, PostDto>().ReverseMap();
			CreateMap<Post, ViewPostDto>().ReverseMap();

			CreateMap<Page, CreateOrEditPageDto>().ReverseMap();
			CreateMap<Page, PageDto>().ReverseMap();
			CreateMap<Page, ViewPageDto>().ReverseMap();


			CreateMap<User, CreateOrEditUserDto>().ReverseMap();
			CreateMap<User, UserDto>().ReverseMap();
			CreateMap<User, ViewUserDto>().ReverseMap();
		}
    }
}
