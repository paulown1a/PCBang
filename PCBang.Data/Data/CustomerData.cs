using PC_Project.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PC_Project.Data
{
    public class CustomerData : EntitiyData<Customer>
    {
        public Customer Get(int customerId)
        {
            PCBangEntities context = CreateContext();
            return context.Customers.FirstOrDefault(a => a.CustomerID == customerId);
        }

        public bool CanUseId(string loginId)
        {
            PCBangEntities context = CreateContext();
            return context.Customers.FirstOrDefault(a => a.LoginID == loginId) == null ? true : false;
        }

        public Customer Login(string loginId, string password)
        {
            PCBangEntities context = CreateContext();
            Customer customer = context.Customers.FirstOrDefault(a => a.LoginID == loginId);
            if (customer == null)
                return null;
            else
            {
                if (customer.LoginPassword == password)
                    return customer;
                else
                    return null;
            }
        }

        public void Delete(int customerId)
        {
            Customer customer = Get(customerId);
            if (customer == null)
                return;
            Delete(customer);
        }

        public void Insert(string name, string loginId, string password)
        {
            Customer newCustomer = new Customer();

            newCustomer.Name = name;
            newCustomer.LoginID = loginId;
            newCustomer.LoginPassword = password;

            Insert(newCustomer);
        }

        
    }
}
