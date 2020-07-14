using System;
using System.Collections.Generic;
using System.Text;

namespace CodeTest
{
    public class TestTwo
    {
        public TestTwo()
        {
            ConsoleLog.LogHeader("Test 2 Begin");

            this.CreateCustomers();
            this.GetFirstCustomer();
            this.UpdateSecondCustomer();
            this.RemoveThirdCustomer();
            this.RemoveAllCustomers();

            ConsoleLog.LogHeader("Test 2 End");
        }

        private void CreateCustomers()
        {
            ConsoleLog.LogSub("Test 2: Create Customers");

            //TODO: Create and add 3 customers to the database, get the customers from the database then print each of their names.            

            ConsoleLog.LogSub("Test 2: Create Customers");
        }

        private void GetFirstCustomer()
        {
            ConsoleLog.LogSub("Test 2: Get First Customer");

            // TODO: Get the first customer added from the database.

            ConsoleLog.LogSub("Test 2 End: Get First Customer");
        }

        private void UpdateSecondCustomer()
        {
            ConsoleLog.LogSub("Test 2: Update Second Customer");

            // TODO: Get the second customer from the database, change their name, resave it to the database then pull it back from the database and print their new name.

            ConsoleLog.LogSub("Test 2 End: Update Second Customer");
        }

        private void RemoveThirdCustomer()
        {
            ConsoleLog.LogSub("Test 2: Remove Third Customer");

            // TODO: Get the third customer from the database, print their name, delete the customer, then prove it no longer exists in the database.

            ConsoleLog.LogSub("Test 2 End: Remove Third Customer");
        }

        private void RemoveAllCustomers()
        {
            ConsoleLog.LogSub("Test 2: Remove All Customers");

            // TODO: Remove all the customers from the database, get all customers from the database and print the count.

            ConsoleLog.LogSub("Test 2 End: Remove All Customers");
        }
    }
}
