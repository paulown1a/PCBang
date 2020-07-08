using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dbdata
{
    public class CustomerData : EntitiyData<Customer>
    {
        public Customer Get(int customerId)
        {
            PCUIEntities context = CreateContext();
            return context.Customers.FirstOrDefault(a => a.CustomerID == customerId);
        }

        public void Delete(int customerId)
        {
            Customer customer = Get(customerId);
            if (customer == null)
                return;
            Delete(customer);
        }
    }
}
