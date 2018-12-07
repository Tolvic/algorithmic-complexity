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
                {"shuffle", StandardLibraryFunctions.ShuffleMethod},
                {"find duplicate numbers", DuplicateAlgorithm.FindDuplicateNumbers},
                {"the best duplicate algorithm", DuplicateAlgorithm.TheBestDuplicateAlgorithm},
                {"shuffle array", ShuffleAlgorithm.ShuffleArray},
                {"shuffle array non list", ShuffleAlgorithm.ShuffleArrayNonList},
                {"insertion sort", SortAlgorithm.InsertionSort}
            };


            string[] funcNames = new string[] {
                "reverse",
                "sort",
                "last",
                "shuffle",
                "find duplicate numbers",
                "the best duplicate algorithm",
                "shuffle array",
                "shuffle array non list",
                "insertion sort"
                };
            FunctionNames = funcNames;
        }


    }


}
