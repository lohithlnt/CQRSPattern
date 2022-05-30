using QueryService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QueryService.Queries.Interfaces
{
    public interface IProductQuery
    {
        Task<IEnumerable<ProductQueryModel>> GetProductsAsync();
        Task<ProductQueryModel> GetProductAsync(int id);
    }
}
