using PC_Project.Data;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PC_Project.Data
{
    public class ProductData : EntitiyData<Product>
    {
        public Product Get(int productId)
        {
            PCBangEntities context = CreateContext();
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
            PCBangEntities context = CreateContext();
            var query = from x in context.Products
                        where x.Name == Name
                        select x.ProductID;
            return query.FirstOrDefault();
        }

        public List<Product> getbycode(int codeId)
        {
            PCBangEntities context = CreateContext();

            var query = from x in context.Products
                        where x.CodeID == codeId
                        select x;
            //select new { album = x, artistname = x.artist.name };
            return query.ToList();
        }

        public void AddPhoth(int productId, string filePath)
        {
            var product = Get(productId);

            if (product == null)
                return;

            product.Photo = File.ReadAllBytes(filePath);

            Update(product);
        }
    }
}
