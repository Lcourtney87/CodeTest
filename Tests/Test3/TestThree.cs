using System;
using System.Collections.Generic;
using System.Text;

namespace CodeTest
{
    public class TestThree
    {
        public TestThree()
        {
            ConsoleLog.LogHeader("Test 3 Begin");
            this.ParseString();

            ConsoleLog.LogHeader("Test 3 End");
        }

        /// <summary>
        /// Strip the numbers out of the 'value' string, then print the numbers in order then print just the letters.
        /// You should be left with 'something' and '123456789
        /// </summary>
        public void ParseString()
        {
            ConsoleLog.LogSub("Test 3: Parse String");

            string value = "s2om74et5h9i3n68g1";

            ConsoleLog.LogSub("Test 3 End: Parse String");
        }
    }
}
