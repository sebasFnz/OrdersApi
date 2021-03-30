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
    public class ControlOrder : IControlOrder
    {
        IDataOrder data;

        public ControlOrder()
        {
            data = new DataOrder();
        }
        public void AddOrder(Order order)
        {
            data.AddOrder(order);
        }

        public void DeleteOrder(long id)
        {
            data.DeleteOrder(id);
        }

        public List<Order> ListOrder()
        {
            return data.ListOrder();
        }

        public Order SearchOrder(long id)
        {
            return data.SearchOrder(id);
        }
    }
}
