using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using SmartCafe.Postgres.DTO;
using SmartCafe.Postgres.Models;

namespace SmartCafe.Postgres.DAL
{
    public interface IProductsDal
    {
        List<ProductDto> GetAllProducts();
        List<CategoryDto> GetAllProductsByCategory();
        List<ProductDto> GetProductsByCategory(int categoryId);
        List<ProductDto> GetProductsBySubCategory(int subCategoryId);
        ProductDto GetProduct(int id);
    }

    public class Products
    {
        private readonly SmartCafeContext _dbContext;
        private readonly IMapper _mapper;

        public Products(SmartCafeContext dbContext, IMapper mapper)
        {
            this._dbContext = dbContext;
            this._mapper = mapper;
        }

        public List<ProductDto> GetAllProducts()
        {
            return this._dbContext.Products.Select(t => this._mapper.Map<ProductDto>(t)).ToList().OrderBy(x => x.Name).ToList();
        }
    }
}
