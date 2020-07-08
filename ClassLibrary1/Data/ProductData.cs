using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dbdata
{
    class ProductData : EntitiyData<Product>
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
    }
}
