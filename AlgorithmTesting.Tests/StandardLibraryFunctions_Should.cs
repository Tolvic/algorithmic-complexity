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
    }
}