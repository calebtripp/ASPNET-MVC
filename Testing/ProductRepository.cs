using System.Collections.Generic;
using System.Data;
using Testing.Models;
using Dapper;

namespace Testing
{
    public class ProductRepository : IProductRepository
    {
        private readonly IDbConnection _conn;
        public ProductRepository(IDbConnection conn)
        {
            _conn = conn;
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return _conn.Query<Product>("SELECT * from PRODUCTS");
        }

        public Product GetProduct(int id)
        {
            return _conn.QuerySingle<Product>("SELECT * from PRODUCTS WHERE ProductID = @id", new { id = id });
        }
    }
}
