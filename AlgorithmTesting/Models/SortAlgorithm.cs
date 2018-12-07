using System;
using System.Collections.Generic;
using System.Linq;

namespace AlgorithmTesting.Models
{
    public class SortAlgorithm
    {
        public static int[] InsertionSort(int[] input)
        {
            List<int> array = input.ToList();
            List<int> result = new List<int>();

            for (int i = 0; i < input.Length; i++)
            {
                //Find the smallest number and add into the result array
                result.Add(array.Min());
                //Remove the smallest number from the original array
                array.Remove(array.Min());
                //Repeat until no more numbers are left
            }

            //Return result
            return result.ToArray();
        }

        public static int[] QuickSort(int[] input)
        {
            List<int> array = input.ToList();
            List<List<int>> result = new List<List<int>>();
            result.Add(array);

            int a = 0;
            do
            {
                Console.WriteLine($"Do loop iteration: {a}");
                int b = 0;

                foreach (List<int> element in result)
                {
                    Console.WriteLine($"ForEach loop iteration: {b}");
                    List<List<int>> temp = new List<List<int>>();

                    if (element.Count > 1)
                    {
                        List<int> pivot = new List<int>();
                        pivot.Add(array[0]);

                        List<int> left = new List<int>();
                        List<int> right = new List<int>();


                        int c = 0;
                        for (int i = 1; i < element.Count; i++)
                        {
                            Console.WriteLine($"For loop iteration: {c}");
                            if (element.ElementAt(i) < pivot[0])
                            {
                                left.Add(element[i]);
                            }
                            else
                            {
                                right.Add(element[i]);
                            }
                            c++;
                        }

                        temp.Add(left);
                        temp.Add(pivot);
                        temp.Add(right);

                    }
                    else
                    {
                        temp.Add(element);
                    }
                    result = temp;
                    b++;
                }
                a++;
            } while (result.Any(element => element.Count > 1));

            var returned = result.SelectMany(i => i).ToArray();

            returned.ToList().ForEach(Console.WriteLine);

            return returned;
        }
    }
}
