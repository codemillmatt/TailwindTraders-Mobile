using System.Collections.Generic;
using System.Threading.Tasks;
using Refit;
using TailwindTraders.Mobile.Features.Settings;

namespace TailwindTraders.Mobile.Features.Product
{
    public interface IProductsAPI
    {
        [Get("/products/{id}")]
        Task<ProductDTO> GetDetailAsync(long id);

        [Get("/products")]
        Task<ProductsPerTypeDTO> GetProductsAsync();

        [Get("/products/category/{category}")]
        Task<ProductsPerTypeDTO> GetProductsByCategoryAsync(string category);
    }
}
