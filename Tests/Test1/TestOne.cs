﻿using System;
using System.Collections.Generic;
using System.Text;

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

            this.CreateCustomer();
            this.GetCustomer();
            this.UpdateCustomer();
            this.DeleteCustomer();
             
            ConsoleLog.LogHeader("Test 1 End");
        }

        /// <summary>
        /// Create a Customer Record and add it to the database.
        /// </summary>
        private void CreateCustomer()
        {
            ConsoleLog.LogSub("Test 1:Create Record");

            // TODO: Add customer

            ConsoleLog.LogSub("Test 1 End:Create Record");
        }

        /// <summary>
        /// Get the Customer Record from the database.
        /// </summary>
        private void GetCustomer()
        {
            ConsoleLog.LogSub("Test 1: Get Record");

            // TODO: Get Customer

            ConsoleLog.LogSub("Test 1 End: Get Record");
        }

        /// <summary>
        /// Find the previously added record and alter the Name, check that the record has been updated in the database.
        /// </summary>
        private void UpdateCustomer()
        {
            ConsoleLog.LogSub("Test 1:Update Record");

            // TODO: Update Customer

            ConsoleLog.LogSub("Test 1 End:Update Record");
        }

        /// <summary>
        /// Find the previously added record and remove it, check the record has been removed from the database.
        /// </summary>
        private void DeleteCustomer()
        {
            ConsoleLog.LogSub("Test 1:Delete Record");

            // TODO: Delete Customer

            ConsoleLog.LogSub("Test 1 End:Delete Record");
        }
    }
}
