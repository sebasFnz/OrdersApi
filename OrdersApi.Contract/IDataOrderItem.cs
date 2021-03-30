using OrdersApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersApi.Contract
{
    public interface IDataOrderItem
    {
        void AddOrderItem(OrderItem orderItem);

        void DeleteOrderItem(long id);

        List<OrderItem> ListOrderItem();

        OrderItem SearchOrderItem(long id);
    }
}
