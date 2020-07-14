﻿using CodeTest.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.Json.Serialization;

namespace CodeTest
{
    public class TestFour
    {
        public TestFour()
        {
            ConsoleLog.LogHeader("Test 4 Begin");            
            this.ConvertJson();

            ConsoleLog.LogHeader("Test 4 End");
        }

        /// <summary>
        /// Convert the Json string into a C# object (typeof ExampleObject) then print the name from the converted object.
        /// </summary>
        public void ConvertJson()
        {
            ConsoleLog.LogSub("Test 4: Convert Json");

            string jsonText;

            #region Json loading
            // Load the embedded Json file in as a string.
            string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tests\Test4\test4Json.txt");
            jsonText = System.IO.File.ReadAllText(path);
            #endregion

            //TODO: Json string should be populated, now do the deserialising.

            List<ExampleObject> examples = JsonConvert.DeserializeObject<List<ExampleObject>>(jsonText);
            foreach(ExampleObject obj in examples.Where(p=> p != null && p.SearchReference == 1))
            {
                ConsoleLog.LogResult($"{obj.Id}");
            }

            ConsoleLog.LogSub("Test 4 End: Convert Json");            
        }
    }
}
