using System;
using System.Collections.Generic;
using System.Linq;

namespace AlgorithmTesting.Models
{
    public class DuplicateAlgorithm
    {
        public static int[] TheBestDuplicateAlgorithm(int[] input)
        {
            List<int> result = new List<int>();

            int [] temp = new int[input.Length];
            int[]check = input;
            for(int i = 0; i < input.Length; i++)
            {
                int Value = check[i];
                if (Array.IndexOf(temp, Value) > -1 && !result.Contains(Value))
                {

                    result.Add(Value);
                }
                temp[i] = check[i];
                result.ToList().ForEach(Console.WriteLine);
            }

            return result.ToArray();
        }
    }
}
