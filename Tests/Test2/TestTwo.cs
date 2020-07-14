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

            ConsoleLog.LogSub("Test 2: Create Customers");
        }

        private void GetFirstCustomer()
        {
            ConsoleLog.LogSub("Test 2: Get First Customer");

            ConsoleLog.LogSub("Test 2 End: Get First Customer");
        }

        private void UpdateSecondCustomer()
        {
            ConsoleLog.LogSub("Test 2: Update Second Customer");

            ConsoleLog.LogSub("Test 2 End: Update Second Customer");
        }

        private void RemoveThirdCustomer()
        {
            ConsoleLog.LogSub("Test 2: Remove Third Customer");

            ConsoleLog.LogSub("Test 2 End: Remove Third Customer");
        }

        private void RemoveAllCustomers()
        {
            ConsoleLog.LogSub("Test 2: Remove All Customers");

            ConsoleLog.LogSub("Test 2 End: Remove All Customers");
        }
    }
}
