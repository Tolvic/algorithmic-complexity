using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace AlgorithmTesting.Models
{
    public class DuplicateAlgorithm
    {
        public static int[] TheBestDuplicateAlgorithm(int[] input)
        {
            List<int> result = new List<int>();

            int[] temp = new int[input.Length];
            int[] check = input;
            for (int i = 0; i < input.Length; i++)
            {
                int Value = check[i];
                if (Array.IndexOf(temp, Value) > -1 && !result.Contains(Value))
                {

                    result.Add(Value);
                }
                temp[i] = check[i];
                //result.ToList().ForEach(Console.WriteLine);
            }

            return result.ToArray();
        }

        public static int[] FindDuplicateNumbers(int[] array)
        {
            //Create result array
            List<int> result = new List<int>();
            //Take array
            var lst = array.ToList();
            var newlst = array.ToList();
            //Get each number in array
            foreach (int number in lst)
            {
                //Remove that number from array
                newlst.Remove(number);
                //Check array for the removed number
                if (newlst.Contains(number))
                {
                    //if number exists then add to new array 
                    result.Add(number);
                    //and remove all matching numbers from original array
                    newlst.RemoveAll(x => x.Equals(number));
                }
                else
                {
                    //else dont
                }
                //Repeat
            }

            return result.ToArray();
        }
    }
}
