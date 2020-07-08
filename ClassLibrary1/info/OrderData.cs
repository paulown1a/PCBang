using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dbdata
{
    public class OrderData : EntitiyData<Order>
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

        public void Insert(int entity)
        {
            PCUIEntities context = CreateContext();

            //context.Albums.Add(album);
            context.Entry(entity).State = EntityState.Added;

            context.SaveChanges();
        }


        public List<Order> GetWithProduct()
        {
            PCUIEntities context = CreateContext();

            var query = from x in context.Orders
                        where x.buyed == false
                        select x;

            var query2 = from x in context.Products
                         select x;

            var orders = query.ToList();

            foreach (var order in orders)
            {
                order.ProductName = query2.FirstOrDefault(x => x.ProductID == order.ProductID).Name;
                order.ProductPrice = query2.FirstOrDefault(x => x.ProductID == order.ProductID).Price;
            }

            return orders;
        }

        public void DeleteOrder(int customerId)
        {
            PCUIEntities context = CreateContext(); 

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

        /*public List<Order> SearchWithProductPrice(int? ProductId, string Name)
        {
            PCUIEntities
                context = CreateContext();

            var query = from x in context.Orders
                        select new { Album = x, ArtistName = x.Artist.Name };

            if (ProductId.HasValue)
                query = query.Where(x => x.Album.ArtistId == ProductId.Value);

            if (string.IsNullOrEmpty(Name) == false)
                query = query.Where(x => x.Album.Title.Contains(Name));

            var items = query.ToList();

            foreach (var item in items)
                item.Album.ArtistName2 = item.ArtistName;

            return items.ConvertAll(x => x.Album);
        }*/
    }
}
