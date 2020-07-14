using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

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
        /// You should be left with 'something' and '123456789'
        /// </summary>
        public void ParseString()
        {
            ConsoleLog.LogSub("Test 3: Parse String");

            string value = "s2om74et5h9i3n68g1";

            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            string nonnumnerics = Regex.Replace(value, @"\d", "");
            string numerics = Regex.Replace(value, @"\D", "").OrderBy(p => p).ToString();

            stopWatch.Stop();
            TimeSpan tsRegex = stopWatch.Elapsed;
            stopWatch.Reset();

            //^^ copied from online.
            // can use linq sort or order by.. but thats no fun! more code!

            stopWatch.Start();

            string numbers = string.Empty;
            string letters = string.Empty;

            for (int loopindex = 0; loopindex < value.Length; loopindex++)
            {
                Char c = value[loopindex];
                if (Char.IsLetter(c))
                {
                    letters += c.ToString();
                }
                else
                {
                        int index = -1;
                        for (int i = 0; i < numbers.Length; i++)
                        {
                            if (c < numbers[i])
                            {
                                index = i;
                                break;
                            }
                        }
                        if (index == -1)
                            numbers += c;
                        else
                            numbers = numbers.Insert(index, c.ToString());
                }
            }

            stopWatch.Stop();
            TimeSpan tsLoop = stopWatch.Elapsed;

            ConsoleLog.LogResult($"{numbers}");
            ConsoleLog.LogResult($"{letters}");

            ConsoleLog.LogSub("Test 3 End: Parse String");
        }
    }
}
