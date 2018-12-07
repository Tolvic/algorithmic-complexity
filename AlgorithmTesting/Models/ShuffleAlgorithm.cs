using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace AlgorithmTesting.Models
{
    public class ShuffleAlgorithm
    {
        public static int[] ShuffleArray(int[] input)
        {
            //Array = []
            List<int> array = input.ToList();
            //Shuffled = []
            List<int> result = new List<int>();
            //Loop
            int count = array.Count;
            Random rnd = new Random();
            for (int i = 0; i < count; i++)
            {
                //i = Random(array.length)
                int n = rnd.Next(0, array.Count - 1);
                //Shuffled << Array.GetAtIndex(i)
                int x = array[n];
                result.Add(x);
                //Array.DeleteAt(i)
                array.RemoveAt(n);
                //Repeat
            }
            return result.ToArray();
        }

        public static int[] ShuffleArrayNonList(int[] input)
        {
            //Create result array
            int[] result = new int[input.Length];
            //Create fake input.length
            int arraylength = input.Length;
            //Initialise random number generator
            Random rnd = new Random();
            //Begin loop
            for (int i = 0; i < input.Length; i++)
            {
                //Get random index
                int n = rnd.Next(0, arraylength);
                //Add input[random number] to results
                result[i] = input[n];
                //Move item at input[random number] to end of input
                    //Assign values at input[random number] and input[arraylength - 1] to temporary variables so they can be swapped
                    int x = input[n];
                    int y = input[arraylength - 1];
                input[n] = y;
                input[arraylength - 1] = x;
                //Decrease fake input.Length
                arraylength--;
            }
            return result;
        }
    }
}
