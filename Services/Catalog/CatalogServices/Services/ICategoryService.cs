using Catalog.Shared.Dtos;
using CatalogServices.Dtos;
using CatalogServices.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CatalogServices.Services
{
    public interface ICategoryService
    {
        Task<Response<List<CategoryDto>>> GetAllAsync();

        Task<Response<CategoryDto>> CreateAsync(CategoryDto category);

        Task<Response<CategoryDto>> GetByIdAsync(string id);
    }
}
