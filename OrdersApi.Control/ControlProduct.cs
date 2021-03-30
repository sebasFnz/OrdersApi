using OrderAPi.Datos;
using OrdersApi.Contract;
using OrdersApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersApi.Control
{
    public class ControlProduct: IControlProduct
    {
        IDataProduct data;

        public ControlProduct()
        {
            data = new DataProduct();
        }

        public void AddProduct(Product product)
        {
            data.AddProduct(product);
        }

        public void DeleteProduct(long id)
        {
            data.DeleteProduct(id);
        }

        public List<Product> ListProduct()
        {
            return data.ListProduct();
        }

        public Product SearchProduct(long id)
        {
            return data.SearchProduct(id);
        }

        public List<Product> SearchByCategory(long category)
        {
            return data.SearchByCategory(category);
        }
    }
}
