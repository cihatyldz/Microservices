using Catalog.Shared.Dtos;
using CatalogServices.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CatalogServices.Services
{
    public interface ICourseService
    {
        Task<Response<List<CourseDto>>> GetAllAsync();

        Task<Response<CourseDto>> GetByIdAsync(string id);

        Task<Response<List<CourseDto>>> GetAllByUserIdAsync(string userId);

        Task<Response<CourseDto>> CreateAsync(CreateCourseDto courseCreateDto);

        Task<Response<NoContent>> UpdateAsync(UpdateCourseDto courseUpdateDto);

        Task<Response<NoContent>> DeleteAsync(string id);
    }
}
