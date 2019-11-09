using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SmartCafe.Postgres.DTO;
using SmartCafe.Postgres.Models;

namespace SmartCafe.Postgres.DAL
{
    public interface IProductsDal
    {
        List<ProductDto> GetAllProducts();
        List<CategoryDto> GetAllProductsByCategory();
        List<SubCategoryDto> GetAllProductsBySubCategory();
        List<ProductDto> GetProductsByCategory(int categoryId);
        List<ProductDto> GetProductsBySubCategory(int subCategoryId);
        ProductDto GetProduct(int id);
    }

    public class Products : IProductsDal
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

        public List<CategoryDto> GetAllProductsByCategory()
        {
            return this._dbContext.Categories.Select(c =>
                new CategoryDto
                {
                    Id = c.Id,
                    Name = c.Name,

                    Products = 
                        this._dbContext.Products.Include(t => t.ProductCategories)
                            .Where(p => p.ProductCategories.Select(pc => pc.CategoryId).Contains(c.Id))
                            .Select(x =>
                                new ProductDto
                                {
                                    Id = x.Id,
                                    Name = x.Name,
                                    IsPromo = x.IsPromo,
                                    IsRecommended = x.IsRecommended,
                                    PriceWithVat = x.PriceWithVat,
                                    Description = x.Description,
                                    Allergens = x.Allergens
                                }
                            )
                            .ToList()
                }
            )
            .OrderBy(c => c.Name)
            .ToList();
        }

        public List<SubCategoryDto> GetAllProductsBySubCategory()
        {
            return this._dbContext.SubCategories.Select(sc =>
                new SubCategoryDto
                {
                    Id = sc.Id,
                    Name = sc.Name,
                    CategoryId = sc.CategoryId,

                    Products =
                        this._dbContext.Products.Include(t => t.ProductSubCategories)
                            .Where(p => p.ProductSubCategories.Select(pc => pc.SubCategoryId).Contains(sc.Id))
                            .Select(x =>
                                new ProductDto
                                {
                                    Id = x.Id,
                                    Name = x.Name,
                                    IsPromo = x.IsPromo,
                                    IsRecommended = x.IsRecommended,
                                    PriceWithVat = x.PriceWithVat,
                                    Description = x.Description,
                                    Allergens = x.Allergens
                                }
                            )
                            .ToList()
                }
            )
            .OrderBy(c => c.Name)
            .ToList();
        }

        public List<ProductDto> GetProductsByCategory(int categoryId)
        {
            return this._dbContext.Products.Include(t => t.ProductCategories)
                        .Where(p => p.ProductCategories.Select(pc => pc.CategoryId).Contains(categoryId))
                            .Select(x =>
                                new ProductDto
                                {
                                    Id = x.Id,
                                    Name = x.Name,
                                    IsPromo = x.IsPromo,
                                    IsRecommended = x.IsRecommended,
                                    PriceWithVat = x.PriceWithVat,
                                    Description = x.Description,
                                    Allergens = x.Allergens
                                }
                            )
                            .ToList();
        }

        public List<ProductDto> GetProductsBySubCategory(int subCategoryId)
        {
            return this._dbContext.Products.Include(t => t.ProductSubCategories)
                        .Where(p => p.ProductSubCategories.Select(pc => pc.SubCategoryId).Contains(subCategoryId))
                            .Select(x =>
                                new ProductDto
                                {
                                    Id = x.Id,
                                    Name = x.Name,
                                    IsPromo = x.IsPromo,
                                    IsRecommended = x.IsRecommended,
                                    PriceWithVat = x.PriceWithVat,
                                    Description = x.Description,
                                    Allergens = x.Allergens
                                }
                            )
                            .ToList();
        }

        public ProductDto GetProduct(int id)
        {
            var product = this._dbContext.Products.FirstOrDefault(p => p.Id == id);
            if (product != null)
            {
                return this._mapper.Map<ProductDto>(product);
            }

            return null;
        }
    }
}
