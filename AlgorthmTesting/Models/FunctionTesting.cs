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
                if (!results.ContainsKey(i)) results.Add(i, new double[1]); // change length when outer loop introduced

                int[] testArray = CreateShuffledArray(i);

                results[i][0] = FunctionExecutionTimer(functionToBeTested, testArray); //changle array reference when outer loop introduced

                counter++;
            }

            return results;
        }

        // Just for dummy testing SpeedTest function
        public static int[] TestFuction(int[] arr)
        {
            return arr;
        }



        private static int[] CreateArrayOfSequentialValues(int i)
        {
            return Enumerable.Range(1, i).ToArray();
        }


        private static int[] CreateShuffledArray(int i)
        {
            int[] arr = CreateArrayOfSequentialValues(i);
         
            new Random().Shuffle(arr);

            return arr;
        }

        private static Double FunctionExecutionTimer(Func<int[], int[]> functionToBeTested, int[] testArray)
        {
            Stopwatch stopWatch = Stopwatch.StartNew();
            functionToBeTested(testArray);
            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;
            return ts.TotalMilliseconds;
        }
      
    }
}
