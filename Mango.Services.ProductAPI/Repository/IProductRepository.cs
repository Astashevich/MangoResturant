﻿using Mango.Services.ProductAPI.Models.Dto;

namespace Mango.Services.ProductAPI.Repository
{
    public interface IProductRepository
    {
        Task<IEnumerable<ProductDto>> GetProducts();
        Task<ProductDto> GetProductById(int id);
        Task<ProductDto> CreateUpdateProduct(ProductDto productDto);
        Task<bool> DeleteProduct(int id);
    }
}
