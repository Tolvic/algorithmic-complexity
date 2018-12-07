using System;
using System.Collections.Generic;
using System.Collections;

namespace AlgorithmTesting.Models
{
    public class AvaialbleFunctions
    {
        public string[] FunctionNames { get; set; }
        public IDictionary<string, Func<int[], int[]>> Functions { get; set; }

        public AvaialbleFunctions()
        {
            Functions = new Dictionary<string, Func<int[], int[]>>(){
                {"reverse",StandardLibraryFunctions.ReverseMethod},
                {"sort", StandardLibraryFunctions.SortMethod},
                {"last", StandardLibraryFunctions.LastMethod},
                {"shuffle", StandardLibraryFunctions.ShuffleMethod}
            };


            string[] funcNames = new string[] {
                "reverse",
                "sort",
                "last",
                "shuffle"
                };
            FunctionNames = funcNames;
        }


    }


}
