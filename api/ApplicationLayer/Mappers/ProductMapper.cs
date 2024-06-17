using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.ApplicationLayer.Dtos;
using api.DataLayer.Entities;

namespace api.ApplicationLayer.Mappers
{
    public static class ProductMapper
    {
        public static ProductDto MapToProductDto(this Product product)
        {
            return new ProductDto
            {
                Name = product.ProductName,
                Description = product.ProductDescription,
                Price = product.ProductPrice,
                Image = product.ProductImage,
                Stock = product.Stock,
                CategoryId = product.CategoryId,
                CategoryName = product.Category.CategoryName
            };
        }


        public static ProductCategoryDto MapToProductCategoryDto(this Product product)
        {
            return new ProductCategoryDto
            {
                Name = product.ProductName,
                Description = product.ProductDescription,
                Price = product.ProductPrice,
                Image = product.ProductImage,
                Stock = product.Stock,
                
            };
        }
    }
}