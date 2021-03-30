using OrdersApi.Contract;
using OrdersApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderAPi.Datos
{
    public class DataOrder : IDataOrder
    {
        OrderDBEntities Db;

        public DataOrder()
        {
            Db = new OrderDBEntities();
        }

        public void AddOrder(Order order)
        {
            Db.Order.Add(order);
            Db.SaveChanges();
        }

        public void DeleteOrder(long id)
        {
            var order = SearchOrder(id);
            if(order != null)
            {
                Db.Order.Remove(order);
                Db.SaveChanges();
            }
        }

        public List<Order> ListOrder()
        {
            return Db.Order.ToList();
        }

        public Order SearchOrder(long id)
        {
            return Db.Order.Find(id);
        }
    }
}
