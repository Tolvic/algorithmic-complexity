using System;
using NUnit.Framework;
using AlgorithmTesting.Models;

namespace AlgorithmTesting.UnitTests.MethodExtensions
{
    public class Tests
    {
        //[SetUp]
        //public void Setup()
        //{
        //}

        [Test]
        public void ShuffleMethod_ReturnsShuffledArray()
        {
            int[] array = { 1, 2 };
            new Random().Shuffle(array);

            Assert.That(array.Length, Is.EqualTo(2));
            Assert.Greater(Array.IndexOf(array, 1), -1);
            Assert.Greater(Array.IndexOf(array, 2), -1);
        }
    }
}