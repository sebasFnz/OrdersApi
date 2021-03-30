using OrdersApi.Contract;
using OrdersApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderAPi.Datos
{
    public class DataProduct : IDataProduct
    {
        OrderDBEntities Db;
        public DataProduct()
        {
            Db = new OrderDBEntities();
        }
        public void AddProduct(Product product)
        {
            Db.Product.Add(product);
            Db.SaveChanges();
        }

        public void DeleteProduct(long id)
        {
            var product = SearchProduct(id);
            if(product != null)
            {
                Db.Product.Remove(product);
            }
        }

        public List<Product> ListProduct()
        {
            return Db.Product.ToList();
        }

        public Product SearchProduct(long id)
        {
            return Db.Product.Find(id);
        }

        public List<Product> SearchByCategory(long category)
        {
            //var pa = Db.Product.Where(x => x.PriceProduct <= 200 && x.IdCategory.Equals(2) ).Select(p=>p.NameProduct).ToList();
            
            return Db.Product.Where(x => x.IdCategory.Equals(category)).ToList();
        }
    }
}
