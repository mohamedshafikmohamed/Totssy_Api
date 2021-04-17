using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Totssy.Models;

namespace Totssy_Api.Models
{
    public class IProductRepos : productRepos
    {
        public void Addproduct(ProductViewModel product, string r)
        {
            throw new NotImplementedException();
        }

        public void DeleteProduct(string Name)
        {
            throw new NotImplementedException();
        }

        public void EditProduct(string Name, string img, ProductViewModel product)
        {
            throw new NotImplementedException();
        }

        public Task<Product> GetProduct(string Name)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Product>> GetProducts()
        {
            throw new NotImplementedException();
        }
    }
}
