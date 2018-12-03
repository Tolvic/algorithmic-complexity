using System;
using System.Diagnostics;
using System.Linq;
using System.Collections.Generic;


namespace AlgorthmTesting.Models
{
    public class FunctionTesting
    {
        public static IDictionary<int, double[]> SpeedTest(Func<int[],int[]> functionToBeTested, int startArraySize, int maxArraySize, int incrementSize)
        {
            IDictionary<int, double[]> results = new Dictionary<int, double[]>();
            int counter = 0;
            for (int i = startArraySize; i < maxArraySize; i+= incrementSize)
            {
                if (!results.ContainsKey(i))
                {
                    results.Add(i, new double[1]); // change length when outer loop introduced
                }
                int[] testArray = Setup(i);
                Stopwatch stopWatch = Stopwatch.StartNew();
                functionToBeTested(testArray);
                stopWatch.Stop();

                Console.WriteLine(functionToBeTested(testArray));

                int[] rs = functionToBeTested(testArray);
                Console.WriteLine($"This is loop {i}");
                foreach (int item in rs)
                {
                    Console.WriteLine(item);
                }






                TimeSpan ts = stopWatch.Elapsed;
                var result = ts.TotalMilliseconds;
      
                results[i][0] = result; //changle array reference when outer loop introduced
                counter++;
            }

            return results;
        }


        public static int[] TestFuction(int[] arr)
        {
            return arr;
        }



        private static int[] CreateArrayOfSequencialValues(int i)
        {
            return Enumerable.Range(1, i).ToArray();
        }


        private static int[] Setup(int i)
        {
            int[] arr = CreateArrayOfSequencialValues(i);
         
            new Random().Shuffle(arr);

            return arr;
        }

    }
}
