/*
 * I have never done unit tests before.
 * 
 * After reading about them, I came to the conclusion
 * that these tests should verify that all things are
 * working as intended.
 */

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzz.Tests
{
    [TestClass]
    public class FizzBuzzTests
    {
        // The FizzBuzz instance is readonly. If we would try to change this in a test method we would get a compile error.
        private readonly FizzBuzz FizzBuzz = new FizzBuzz();

        // The next few values should not change during the tests that is why they are constant values.
        private const int Three = 3;
        private const int Five = 5;
        private const int Fifteen = 15;

        private const string FizzExpected = "Fizz";
        private const string BuzzExpected = "Buzz";
        private const string FizzBuzzExpected = "FizzBuzz";

        [TestMethod]
        public void IsAMultipleOfTest()
        {
            Assert.IsTrue(FizzBuzz.IsMultipleOf(Three, Three));
        }
        [TestMethod]
        public void IsNotAMultipleOfTest()
        {
            Assert.IsFalse(FizzBuzz.IsMultipleOf(Five, Three));
        }
        [TestMethod]
        public void IsMultipleOfReturnTypeTest()
        {
            Assert.IsInstanceOfType(FizzBuzz.IsMultipleOf(Three, Three), typeof(bool));
        }
        [TestMethod]
        public void FizzAndBuzzReturnTypeTest()
        {
            Assert.IsInstanceOfType(FizzBuzz.FizzAndBuzz(Three), typeof(string));
        }
        [TestMethod]
        public void IsFizzTest()
        {
            Assert.AreEqual(FizzExpected, FizzBuzz.FizzAndBuzz(Three));
        }
        [TestMethod]
        public void IsNotFizzTest()
        {
            Assert.AreNotEqual(FizzExpected, FizzBuzz.FizzAndBuzz(Five));
        }
        [TestMethod]
        public void IsBuzzTest()
        {
            Assert.AreEqual(BuzzExpected, FizzBuzz.FizzAndBuzz(Five));
        }
        [TestMethod]
        public void IsNotBuzzTest()
        {
            Assert.AreNotEqual(BuzzExpected, FizzBuzz.FizzAndBuzz(Three));
        }
        [TestMethod]
        public void IsFizzBuzzTest()
        {
            Assert.AreEqual(FizzBuzzExpected, FizzBuzz.FizzAndBuzz(Fifteen));
        }
        [TestMethod]
        public void IsNotFizzBuzzTest()
        {
            Assert.AreNotEqual(FizzBuzzExpected, FizzBuzz.FizzAndBuzz(Three));
        }
    }
}