using System;
namespace AlgorthmTesting.Models
{
    public static class MethodExtensions
    {
       public static void Shuffle<T>(this Random rng, T[] array)
        {
            // Method uses Fisher Yates Algorthim 
            // Source: https://stackoverflow.com/questions/108819/best-way-to-randomize-an-array-with-net
            int n = array.Length;
            while (n > 1)
            {
                int k = rng.Next(n--);
                T temp = array[n];
                array[n] = array[k];
                array[k] = temp;
            }
        }


    }
}
