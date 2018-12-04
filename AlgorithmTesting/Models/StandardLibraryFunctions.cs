using System;
using System.Linq;

namespace AlgorithmTesting.Models
{
    public class StandardLibraryFunctions
    {
        public static int[] ReverseMethod(int[] array)
        {
            Array.Reverse(array);
            return array;
        }

        public static int[] SortMethod(int[] array)
        {
            Array.Sort(array);
            return array;
        }

        public static int[] LastMethod(int[] array)
        {
            int[] result = { array[array.Length - 1] };
            return result;
        }

        public static int[] ShuffleMethod(int[] array)
        {
            var result = array;
            new Random().Shuffle(result);
            return result;
        }
    }
}
