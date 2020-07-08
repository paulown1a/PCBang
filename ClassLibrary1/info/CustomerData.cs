﻿using System;
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

        public bool CanUseId(string loginId)
        {
            PCUIEntities context = CreateContext();
            return context.Customers.FirstOrDefault(a => a.LoginID == loginId) == null?true:false;
        }

        public Customer Login(string ID, string Password)
        {
            PCUIEntities context = CreateContext();
            Customer customer = context.Customers.FirstOrDefault(a => a.LoginID == ID);
            if (customer == null)
                return null;
            else
            {
                if (customer.LoginPassword == Password)
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

        public void Insert(string name, string iD, string password)
        {
            Customer newCustomer = new Customer();
            newCustomer.Name = name;

            
            newCustomer.LoginID = iD;
            
            newCustomer.LoginPassword = password;

            Insert(newCustomer);
        }
    }
}
