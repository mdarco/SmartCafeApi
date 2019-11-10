using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SmartCafe.Postgres.DAL;
using SmartCafe.Postgres.DTO;

namespace SmartCafe.Postgres.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductsDal _dal;
        private readonly ILogger<ProductsController> _logger;

        public ProductsController(IProductsDal dal, ILogger<ProductsController> logger)
        {
            this._dal = dal;
            this._logger = logger;
        }

        [HttpGet]
        public ActionResult<List<ProductDto>> GetAllProducts()
        {
            var products = this._dal.GetAllProducts();
            return Ok(products);
        }

        [Route("categories")]
        [HttpGet]
        public ActionResult<List<CategoryDto>> GetAllProductsByCategory()
        {
            var products = this._dal.GetAllProductsByCategory();
            return Ok(products);
        }

        [Route("categories/{categoryId}")]
        [HttpGet]
        public ActionResult<List<ProductDto>> GetProductsByCategory(int categoryId)
        {
            var products = this._dal.GetProductsByCategory(categoryId);
            return Ok(products);
        }

        [Route("sub-categories")]
        [HttpGet]
        public ActionResult<List<CategoryDto>> GetAllProductsBySubCategory()
        {
            var products = this._dal.GetAllProductsBySubCategory();
            return Ok(products);
        }

        [Route("sub-categories/{subCategoryId}")]
        [HttpGet]
        public ActionResult<List<ProductDto>> GetProductsBySubCategory(int subCategoryId)
        {
            var products = this._dal.GetProductsBySubCategory(subCategoryId);
            return Ok(products);
        }

        [HttpGet]
        [Route("{id}")]
        public ActionResult<ProductDto> GetProduct(int id)
        {
            var product = this._dal.GetProduct(id);
            return Ok(product);
        }
    }
}