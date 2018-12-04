using System;
using NUnit.Framework;
using AlgorithmTesting.Models;

namespace AlgorithmTesting.UnitTests
{
    public class DuplicateAlgorithmTests
    {
        [SetUp]
        public void Setup()
        {
        }
        [Test]
        public void Duplicate_ReturnsArrayOfDuplicates()
        {
            int[] array = { 1, 2, 2, 4, 3, 6, 7, 3, 4, 5, 6, 2, 4 };
            int[] result = DuplicateAlgorithm.FindDuplicateNumbers(array);
            Array.Sort(result);
            int[] expected = { 2, 3, 4, 6 };
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}