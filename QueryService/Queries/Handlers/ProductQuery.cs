using CommonData;
using Microsoft.EntityFrameworkCore;
using QueryService.Models;
using QueryService.Queries.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QueryService.Queries.Handlers
{
    public class ProductQuery : IProductQuery
    {
        AppDbContext _db;
        public ProductQuery(AppDbContext db)
        {
            _db = db;
        }
        public async Task<ProductQueryModel> GetProductAsync(int id)
        {
            var data = await _db.Products.Where(p => p.ProductId == id).Select(p => new ProductQueryModel
            {
                ProductId = p.ProductId,
                Name = p.Name,
                Description = p.Description,
                Price = p.Price
            }).FirstOrDefaultAsync();

            return data;
        }

        public async Task<IEnumerable<ProductQueryModel>> GetProductsAsync()
        {
            var data = await _db.Products.Select(p => new ProductQueryModel
            {
                ProductId = p.ProductId,
                Name = p.Name,
                Description = p.Description,
                Price = p.Price
            }).ToListAsync();

            return data;
        }
    }
}
