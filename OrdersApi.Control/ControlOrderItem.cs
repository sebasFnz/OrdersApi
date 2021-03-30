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
    public class ControlOrderItem: IControlOrderItem
    {
        IDataOrderItem data;

        public ControlOrderItem()
        {
            data = new DataOrderItem();
        }

        public void AddOrderItem(OrderItem orderItem)
        {
            data.AddOrderItem(orderItem);
        }

        public void DeleteOrderItem(long id)
        {
            data.DeleteOrderItem(id);
        }

        public List<OrderItem> ListOrderItem()
        {
            return data.ListOrderItem();
        }

        public OrderItem SearchOrderItem(long id)
        {
            return data.SearchOrderItem(id);
        }
    }
}
