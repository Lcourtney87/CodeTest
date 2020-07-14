using CodeTest.Database.Services;
using CodeTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeTest
{
    public class TestTwo
    {
        public TestTwo()
        {
            ConsoleLog.LogHeader("Test 2 Begin");

            List<Customer> customers = this.CreateCustomers();
            this.GetFirstCustomer(customers[0].Id);
            this.UpdateSecondCustomer(customers[1]);
            this.RemoveThirdCustomer(customers[2].Id);
            this.RemoveAllCustomers();

            ConsoleLog.LogHeader("Test 2 End");
        }

        private List<Customer> CreateCustomers()
        {
            ConsoleLog.LogSub("Test 2: Create Customers");

            List<Customer> customers = new List<Customer>();

            customers.Add( new Customer()
            {
                Id = 1,
                Address = "Somewhere over the rainbow",
                Name = "Jimmy",
                Phonenumber = "0000001",
                Postcode = "WA3DF32"
            });
            customers.Add(new Customer()
            {
                Id = 2,
                Address = "down under",
                Name = "Rolf",
                Phonenumber = "0000002",
                Postcode = "234SDD"
            }); customers.Add(new Customer()
            {
                Id = 3,
                Address = "Head office",
                Name = "Tom",
                Phonenumber = "0000003",
                Postcode = "GH46DDF"
            });

            Service.Add(customers[0]);
            Service.Add(customers[1]);
            Service.Add(customers[2]);

            int finalCount = Service.GetAll().Count;
            ConsoleLog.LogResult($"Customers Added, count = {finalCount}");

            ConsoleLog.LogSub("Test 2: Create Customers");
            return customers;
        }

        private void GetFirstCustomer(int id)
        {
            ConsoleLog.LogSub("Test 2: Get First Customer");

            Customer customer = Service.Get(id);
            ConsoleLog.LogResult($"Customers get, name = {customer.Name}");

            ConsoleLog.LogSub("Test 2 End: Get First Customer");
        }

        private void UpdateSecondCustomer(Customer customer)
        {
            ConsoleLog.LogSub("Test 2: Update Second Customer");

            ConsoleLog.LogResult($"Customers name = {customer.Name}");
            customer.Name = "Undercover";
            Service.Update(customer);
            customer = Service.Get(customer.Id);
            ConsoleLog.LogResult($"Customers changed name = {customer.Name}");

            ConsoleLog.LogSub("Test 2 End: Update Second Customer");
        }

        private void RemoveThirdCustomer(int id)
        {
            ConsoleLog.LogSub("Test 2: Remove Third Customer");

            Service.Delete(id);
            List<Customer> customers = Service.GetAll();
            ConsoleLog.LogResult($"Remaining customers:");
            foreach (Customer customer in customers)
            {
                ConsoleLog.LogResult($"{customer.Name}");
            }

            ConsoleLog.LogSub("Test 2 End: Remove Third Customer");
        }

        private void RemoveAllCustomers()
        {
            ConsoleLog.LogSub("Test 2: Remove All Customers");

            List<Customer> customers = Service.GetAll().ToList();
            foreach (Customer customer in customers)
            {
                Service.Delete(customer.Id);
                ConsoleLog.LogResult($"Customers {customer.Name} deleted");
            }

            customers = Service.GetAll();
            foreach (Customer customer in customers)
            {
                ConsoleLog.LogResult($"Theres going to be nothing here!");
            }

            ConsoleLog.LogSub("Test 2 End: Remove All Customers");
        }
    }
}
