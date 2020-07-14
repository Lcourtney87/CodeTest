using CodeTest.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CodeTest.Database.Services
{
    public static class Service
    {
        public static List<Customer> GetAll()
        {
            using (Database context = new Database())
            {
                return context.Customers.ToList();
            }
        }

        public static Customer Get(int id)
        {
            using (Database context = new Database())
            {
                Customer example = context.Customers.FirstOrDefault(p => p.Id == id);
                return example;
            }
        }

        public static int Add(Customer customer)
        {
            using (Database context = new Database())
            {
                var newCustomer = context.Customers.Add(customer);
                context.SaveChanges();
                return newCustomer.Entity.Id;
            }
        }

        public static void Update(Customer customer)
        {
            using (Database context = new Database())
            {
                context.Customers.Update(customer);
                context.SaveChanges();
            }
        }

        public static void Delete(int id)
        {
            using (Database context = new Database())
            {
                Customer customer = context.Customers.FirstOrDefault(p => p.Id == id);
                context.Customers.Remove(customer);
                context.SaveChanges();
            }
        }
    }
}
