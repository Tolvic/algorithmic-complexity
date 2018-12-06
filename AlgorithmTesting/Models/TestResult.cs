using System;
using System.Collections.Generic;

namespace AlgorithmTesting.Models
{
    public class TestResult
    {
        public string TestedMethodName { get; set; }
        public IDictionary<int, double> TestResults { get; set; }
        public int[] ArraySizes { get; set; }

        public TestResult(string name, IDictionary<int, double> test)
        {
            TestedMethodName = name;
            TestResults = test;

            List<int> temp = new List<int>();

            foreach (KeyValuePair<int, double> entry in test)
            {
                temp.Add(entry.Key);

            }
            ArraySizes = temp.ToArray();

        }

    }


}
