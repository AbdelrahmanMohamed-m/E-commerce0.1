using api.ApplicationLayer.Dtos;
using api.DataLayer;

namespace api.ApplicationLayer.IService
{
    public interface IProductService
    {

        public Task<List<ProductDto>> GetAllProducts(QueryProductObject queryable);
    }
}