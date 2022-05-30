using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QueryService.Models;
using QueryService.Queries.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QueryService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private IProductQuery _productQuery;
        public ProductController(IProductQuery productQuery)
        {
            _productQuery = productQuery;
        }

        [HttpGet]
        public async Task<IEnumerable<ProductQueryModel>> GetProducts()
        {
            return await _productQuery.GetProductsAsync();
        }

        [HttpGet("{id}")]
        public async Task<ProductQueryModel> GetProduct(int id)
        {
            return await _productQuery.GetProductAsync(id);
        }
    }
}
