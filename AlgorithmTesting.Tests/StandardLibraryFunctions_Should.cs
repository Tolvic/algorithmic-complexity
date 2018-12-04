using System;
using NUnit.Framework;
using AlgorithmTesting.Models;

namespace AlgorithmTesting.UnitTests.StandardLibraryFunction
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ReverseMethod_ReturnsReversedArray()
        {
            int[] array = { 1, 2, 3 };
            int[] expected = { 3, 2, 1 };
            Assert.That(StandardLibraryFunctions.ReverseMethod(array), Is.EqualTo(expected));
        }

        [Test]
        public void LastMethod_ReturnsLastNumberInArray()
        {
            int[] array = { 1, 2, 3 };
            int[] expected = { 3 };
            Assert.That(StandardLibraryFunctions.LastMethod(array), Is.EqualTo(expected));
        }

        [Test]
        public void SortMethod_ReturnsSortedArray()
        {
            int[] array = { 2, 1, 3 };
            int[] expected = { 1, 2, 3 };
            Assert.That(StandardLibraryFunctions.SortMethod(array), Is.EqualTo(expected));
        }

        [Test]
        public void ShuffleMethod_ReturnsShuffledArray()
        {
            int[] array = { 1, 2 };
            int[] result = StandardLibraryFunctions.ShuffleMethod(array);

            Assert.That(result.Length, Is.EqualTo(2));
            Assert.Greater(Array.IndexOf(result, 1), -1);
            Assert.Greater(Array.IndexOf(result, 2), -1);
        }
    }
}