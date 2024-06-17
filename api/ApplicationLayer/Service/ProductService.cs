using api.ApplicationLayer.Dtos;
using api.ApplicationLayer.IService;
using api.ApplicationLayer.Mappers;
using api.DataLayer;
using api.InfrastructureLayer.IRepos;

namespace api.ApplicationLayer.Service
{
    public class ProductService : IProductService
    {
        private readonly IProductRepo _product;
        public ProductService(IProductRepo productRepo)
        {
            _product = productRepo;
        }
        public async Task<List<ProductDto>> GetAllProducts(QueryProductObject queryable)
        {
            var products = await _product.GetallProducts(queryable);

            if (!string.IsNullOrEmpty(queryable.ProductName))
            {
                products = products.Where(x => x.ProductName.Contains(queryable.ProductName)).ToList();
            }
            if (queryable.SortBy == "ProductName")
            {
                products = queryable.IsDesending ? products.OrderByDescending(x => x.ProductName).ToList() : products.OrderBy(x => x.ProductName).ToList();
            }
            var pagination = products.Skip((queryable.PageNumber - 1) * queryable.PageSize).Take(queryable.PageSize).ToList();
            return pagination.Select(x => x.MapToProductDto()).ToList();

        }
    }
}