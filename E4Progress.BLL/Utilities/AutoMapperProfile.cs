using AutoMapper;
using E4Progress.DAL.Entities;
using E4Progress.Domain.DTO;
 
namespace E4Progress.BLL.Utilities
{
  public  class AutoMapperProfile:Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<UserDto, User>().ReverseMap();
            CreateMap<CourseDto, Course>().ReverseMap();
        }
    }
}
