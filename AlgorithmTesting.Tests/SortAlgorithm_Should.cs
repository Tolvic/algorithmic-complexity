using System;
using NUnit.Framework;
using AlgorithmTesting.Models;
using System.Collections.Generic;
using System.Linq;

namespace AlgorithmTesting.UnitTests
{
    public class SortAlgorithmTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void InsertionSort_ReturnsASortedArray()
        {
            int[] array = { 9, 1, 8, 2, 7, 3, 6, 4, 5 };
            int[] result = SortAlgorithm.InsertionSort(array);
            int[] expected = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void QuickSort_ReturnsSortedArray()
        {
            int[] array = { 9, 1, 8, 2, 7, 3, 6, 4, 5 };
            int[] result = SortAlgorithm.QuickSort(array);
            int[] expected = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}