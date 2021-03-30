using OrdersApi.Contract;
using OrdersApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderAPi.Datos
{
    public class DataOrderItem : IDataOrderItem
    {
        OrderDBEntities Db;

        public DataOrderItem()
        {
            Db = new OrderDBEntities();
        }
        public void AddOrderItem(OrderItem orderItem)
        {
            Db.OrderItem.Add(orderItem);
            Db.SaveChanges();
        }

        public void DeleteOrderItem(long id)
        {
            var orderItem = SearchOrderItem(id);
            if(orderItem != null)
            {
                
                Db.OrderItem.Remove(orderItem);
                Db.SaveChanges();
            }
        }

        public List<OrderItem> ListOrderItem()
        {
            return Db.OrderItem.ToList();
        }

        public OrderItem SearchOrderItem(long id)
        {
            return Db.OrderItem.Find(id);
        }
    }
}
