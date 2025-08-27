
using Mango.Services.Order.API.Models;


namespace Mango.Services.Order.API.Service.IService
{
    public interface IProductService
    {
        Task<IEnumerable<ProductDto>> GetProducts();
    }
}
