using NUnit.Framework;
using FizzBuzzApp;
namespace FizzBuzzApp.Tests
{
    public class FizzBuzzTests
    {
        private FizzBuzz _fizzBuzz;

        [SetUp]
        public void Setup()
        {
            _fizzBuzz = new FizzBuzz();
        }

        [Test]
        public void GetFizzBuzz_InputIs3_ReturnsFizz()
        {
            int input = 3;
            string result = _fizzBuzz.GetFizzBuzz(input);

            Assert.AreEqual("Fizz", result);
        }

        [Test]
        public void GetFizzBuzz_InputIs5_ReturnsBuzz()
        {
            int input = 5;
            string result = _fizzBuzz.GetFizzBuzz(input);

            Assert.AreEqual("Buzz", result);
        }

        [Test]
        public void GetFizzBuzz_InputIs15_ReturnsFizzBuzz()
        {
            int input = 15;
            string result = _fizzBuzz.GetFizzBuzz(input);

            Assert.AreEqual("FizzBuzz", result);
        }

        [Test]
        public void GetFizzBuzz_InputIsAnotherNumber_ReturnsNumber()
        {
            int input = 17;
            string result = _fizzBuzz.GetFizzBuzz(input);

            Assert.AreEqual("17", result);
        }
    }
}
