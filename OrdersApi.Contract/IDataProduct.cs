using OrdersApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersApi.Contract
{
    public interface IControlProduct
    {
        void AddProduct(Product product);

        Product SearchProduct(long id);

        List<Product> ListProduct();

        void DeleteProduct(long id);

        List<Product> SearchByCategory(long category);
    }
}
