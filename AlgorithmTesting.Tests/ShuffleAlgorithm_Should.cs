using System;
using NUnit.Framework;
using AlgorithmTesting.Models;
using System.Collections.Generic;
using System.Linq;

namespace AlgorithmTesting.UnitTests
{
    public class ShuffleAlgorithmTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ShuffleReturnsShuffledArray()
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int[] result = ShuffleAlgorithm.ShuffleArray(array);
            Assert.That(result.Length, Is.EqualTo(array.Length));
        }

        [Test]
        public void ShuffleArrayNonListReturnsShuffledArray()
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int[] result = ShuffleAlgorithm.ShuffleArrayNonList(array);
            Assert.That(result.Length, Is.EqualTo(array.Length));
        }
    }
}