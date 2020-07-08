using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dbdata
{
    class OrderData : EntitiyData<Order>
    {
        public Order Get(int orderId)
        {
            PCUIEntities context = CreateContext();
            return context.Orders.FirstOrDefault(a => a.OrderID == orderId);
        }

        public void Delete(int orderId)
        {
            Order order = Get(orderId);
            if (order == null)
                return;
            Delete(order);
        }
    }
}
