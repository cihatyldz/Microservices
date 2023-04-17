using AutoMapper;
using CatalogServices.Dtos;
using CatalogServices.Models;

namespace CatalogServices.Mapping
{
    public class GeneralMapping:Profile
    {
        public GeneralMapping()
        {
            CreateMap<Course, CourseDto>().ReverseMap();
            CreateMap<Course, CreateCourseDto>().ReverseMap();
            CreateMap<Course, UpdateCourseDto>().ReverseMap();

            CreateMap<Category, CategoryDto>().ReverseMap();
            CreateMap<Feature, FeatureDto>().ReverseMap();
        }
    }
}
