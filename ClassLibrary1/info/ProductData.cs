using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dbdata
{
    public class ProductData : EntitiyData<Product>
    {
        public Product Get(int productId)
        {
            PCUIEntities context = CreateContext();
            return context.Products.FirstOrDefault(a => a.ProductID == productId);
        }

        public void Delete(int productId)
        {
            Product product = Get(productId);
            if (product == null)
                return;
            Delete(product);
        }

        public int? GetByName(string Name)
        {
            PCUIEntities context = CreateContext();
            var query = from x in context.Products
                        where x.Name == Name
                        select x.ProductID;
            return query.FirstOrDefault();
        }

        public List<Product> getbycode(int codeId)
        {
            PCUIEntities context = CreateContext();

            var query = from x in context.Products
                        where x.CodeID == codeId
                        select x;
            //select new { album = x, artistname = x.artist.name };
            return query.ToList();



        }
    }
}
