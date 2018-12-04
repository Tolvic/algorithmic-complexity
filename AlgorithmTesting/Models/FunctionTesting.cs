using System;
using System.Diagnostics;
using System.Linq;
using System.Collections.Generic;
using AlgorithmTesting.Models;

namespace AlgorithmTesting.Models
{
    public class FunctionTesting
    {
        public static IDictionary<int, double> SpeedTest(Func<int[],int[]> functionToBeTested, int startArraySize, int maxArraySize, int incrementSize, int NumberTimesTestsRepeated, string ArrayType = "sequential", string AverageType = "median")
        {
            IDictionary<int, double[]> results = new Dictionary<int, double[]>();

            for (int n = 0; n < NumberTimesTestsRepeated; n++) 
            {
                for (int i = startArraySize; i <= maxArraySize; i += incrementSize)
                {
                    if (!results.ContainsKey(i)) results.Add(i, new double[NumberTimesTestsRepeated]); // on first iteration adds an empty array to the results dictionary

                    int[] testArray = CreateShuffledArray(i, ArrayType);

                    results[i][n] = FunctionExecutionTimer(functionToBeTested, testArray);
                }

            }

            return CalculateAverages(results, AverageType);
        }

        // Just for dummy testing SpeedTest function
        public static int[] TestFuction(int[] arr)
        {
            //Console.WriteLine(arr.Length);
            foreach(int value in arr)
            {
                Console.WriteLine(value);
            }
            return arr;
        }

        private static int[] CreateArrayOfSequentialValues(int i)
        {
            return Enumerable.Range(1, i).ToArray();
        }

        private static int[] CreateArrayOfRandomValues(int i)
        {
            Random rnd = new Random;
            int[] arr = new int[i];
            for(int n = 0; n < i; n++)
            {
                rnd.Next(10);
            };
            return arr;
        }

        private static int[] CreateShuffledArray(int i, string type = "sequential")
        {
            int[] arr;
            if (type == "sequential")
            {
                arr = CreateArrayOfSequentialValues(i);
            }
            else
            {
                arr = CreateArrayOfRandomValues(i);
            }

            new Random().Shuffle(arr);

            return arr;
        }

        private static Double FunctionExecutionTimer(Func<int[], int[]> functionToBeTested, int[] testArray)
        {
            Stopwatch stopWatch = Stopwatch.StartNew();
            functionToBeTested(testArray);
            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;
            return ts.TotalMilliseconds * 1000000;
        }

        public static IDictionary<int, double> CalculateAverages(IDictionary<int, double[]> results, string type = "mean")
        {
            IDictionary<int, double> averageResults = new Dictionary<int, double>();

            if (type == "median")
            {
                foreach (var item in results)
                {
                    int numberCount = item.Value.Count();
                    int halfIndex = numberCount / 2;
                    int halfIndex2 = halfIndex - 1;

                    var sortedNumbers = item.Value.OrderBy(n => n);
                    double median;
                    if ((numberCount % 2) == 0)
                    {
                        median = ((sortedNumbers.ElementAt(halfIndex) +
                            sortedNumbers.ElementAt(halfIndex2)) / 2);
                    }
                    else
                    {
                        median = sortedNumbers.ElementAt(halfIndex);
                    }
                    averageResults[item.Key] = median;
                }
            }
            else if (type == "mean")
            {
                foreach (var item in results)
                {
                    double sum = 0;

                    for (int i = 0; i < item.Value.Length; i++)
                    {
                        sum += item.Value[i];
                    }
                    averageResults[item.Key] = sum / item.Value.Length;
                }
            }

            return averageResults;
        }

    }
}
