using CodeTest.Database.Services;
using System;
using System.Collections.Generic;
using System.Text;
using CodeTest.Models;
using CodeTest.Database;

namespace CodeTest
{
    public class TestOne
    {
        /// <summary>
        /// Initialiser, no need to touch this.
        /// </summary>
        public TestOne()
        {
            ConsoleLog.LogHeader("Test 1 Begin");

            Customer customer = new Customer()
            {
                Id = 1,
                Address = "Somewhere over the rainbow",
                Name = "Jimmy",
                Phonenumber = "0000001",
                Postcode = "WASDF32"
            };

            int newID = this.CreateCustomer(customer);

            Customer newCustomer = this.GetCustomer(newID);

            this.UpdateCustomer(newCustomer);

            this.DeleteCustomer(newID);

            ConsoleLog.LogHeader("Test 1 End");
        }

        /// <summary>
        /// Create a Customer Record and add it to the database.
        /// </summary>
        private int CreateCustomer(Customer customer)
        {
            ConsoleLog.LogSub("Test 1:Create Record");

            int newID = Service.Add(customer);
            ConsoleLog.LogResult($"Customer Added, ID:{newID}");

            ConsoleLog.LogSub("Test 1 End:Create Record");
            return newID;
        }

        /// <summary>
        /// Get the Customer Record from the database.
        /// </summary>
        private Customer GetCustomer(int id)
        {
            ConsoleLog.LogSub("Test 1: Get Record");

            Customer returnVal = Service.Get(id);
            ConsoleLog.LogResult($"Customer returned, Name:{returnVal.Name}");

            ConsoleLog.LogSub("Test 1 End: Get Record");
            return returnVal;
        }

        /// <summary>
        /// Find the previously added record and alter the Name, check that the record has been updated in the database.
        /// </summary>
        private void UpdateCustomer(Customer customer)
        {
            ConsoleLog.LogSub("Test 1:Update Record");

            ConsoleLog.LogResult($"Original name:{customer.Name}");
            customer.Name = "schoolbus";
            Service.Update(customer);
            Customer updatedCustomer = Service.Get(customer.Id);
            ConsoleLog.LogResult($"New Name:{updatedCustomer.Name}");

            ConsoleLog.LogSub("Test 1 End:Update Record");
        }

        /// <summary>
        /// Find the previously added record and remove it, check the record has been removed from the database.
        /// </summary>
        private void DeleteCustomer(int id)
        {
            ConsoleLog.LogSub("Test 1:Delete Record");

            int orginalCount = Service.GetAll().Count;
            ConsoleLog.LogResult($"Original count:{orginalCount}");
            Service.Delete(id);
            int NewCount = Service.GetAll().Count;
            ConsoleLog.LogResult($"New count:{NewCount}");

            ConsoleLog.LogSub("Test 1 End:Delete Recordasd");
        }
    }
}
