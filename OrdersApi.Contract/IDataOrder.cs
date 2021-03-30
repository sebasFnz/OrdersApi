using OrdersApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersApi.Contract
{
    public interface IDataOrder
    {
        void AddOrder(Order order);

        Order SearchOrder(long id);

        List<Order> ListOrder();

        void DeleteOrder(long id);

    }
}
