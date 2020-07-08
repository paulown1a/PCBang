using PC_Project.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PC_Project.Data
{
    public partial class Order
    {
        public string ProductName { get; set; }
        public int ProductPrice { get; set; }
    }

    public class OrderData : EntitiyData<Order>
    {
        public Order Get(int orderId)
        {
            PCBangEntities context = CreateContext();
            return context.Orders.FirstOrDefault(x => x.OrderID == orderId);
        }

        public void Delete(int orderId)
        {
            Order order = Get(orderId);
            if (order == null)
                return;
            Delete(order);
        }
        public List<Order> GetWithProduct(bool buyed)
        {
            PCBangEntities context = CreateContext();
            var query = from x in context.Orders
                        where x.buyed == buyed
                        select x;
            var orders = query.ToList();

            foreach (var order in orders)
            {
                order.ProductName = context.Products.FirstOrDefault(x => x.ProductID == order.ProductID).Name;
                order.ProductPrice = context.Products.FirstOrDefault(x => x.ProductID == order.ProductID).Price;
            }

            return orders;
        }
        public void Insert(int entity)
        {
            PCBangEntities context = CreateContext();

            //context.Albums.Add(album);
            context.Entry(entity).State = EntityState.Added;

            context.SaveChanges();
        }

        public void DeleteOrder(int customerId)
        {
            PCBangEntities context = CreateContext();

            var query = from x in context.Orders
                        where x.buyed == false && x.CustomerID == customerId
                        select x;

            List<Order> orders = query.ToList();

            if (orders != null)
                foreach (var order in orders)
                {
                    Delete(order);
                }

        }

    }
}
