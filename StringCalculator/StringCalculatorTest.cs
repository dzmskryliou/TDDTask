namespace TDDProject
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Return0WhenReceiveEmpty()
        {
            var calculator = new StringCalculator();
            var result = calculator.Add("");
            Assert.AreEqual(0, result);
        }

        [Test]
        public void ReturnNumberWhenReceivesTheNumber()
        {
            var calculator = new StringCalculator();
            var result = calculator.Add("1");
            Assert.AreEqual(1, result);
        }

        [Test]
        public void ReturnSumWhenReceivesTwoNumbers()
        {
            var calculator = new StringCalculator();
            var result = calculator.Add("1,2");
            Assert.AreEqual(3, result);
        }

        [Test]
        public void ReturnSumWhenReceivesSeveralNumbers()
        {
            var calculator = new StringCalculator();
            var result = calculator.Add("1,2,3,4");
            Assert.AreEqual(10, result);
        }

        [Test]
        public void ReturnSumWhenReceivesCustomDelimiter()
        {
            var calculator = new StringCalculator();
            var result = calculator.Add("//;\n1;2");
            Assert.AreEqual(3, result);
        }

        [Test]
        public void DoNotReturnSumWhenReceivesNegativeNumber()
        {
            var calculator = new StringCalculator();

            bool exceptionThrown = false;
            try
            {
                calculator.Add("1,2,3,-4");
            }
            catch (Exception ex)
            {
                exceptionThrown = true;
                Assert.AreEqual("Negatives not allowed: -4", ex.Message);
            }

            Assert.IsTrue(exceptionThrown, "Expected exception was not thrown.");
        }

        [Test]
        public void DoNotReturnSumWhenReceivesSeveralNegativeNumbers()
        {
            var calculator = new StringCalculator();

            bool exceptionThrown = false;
            try
            {
                calculator.Add("1,-2,3,-4");
            }
            catch (Exception ex)
            {
                exceptionThrown = true;
                Assert.AreEqual("Negatives not allowed: -2, -4", ex.Message);
            }

            Assert.IsTrue(exceptionThrown, "Expected exception was not thrown.");
        }

        [Test]
        public void DoNotReturnSumWhenReceivesInvalidNumber()
        {
            var calculator = new StringCalculator();

            bool exceptionThrown = false;
            try
            {
                calculator.Add("1,2,a");
            }
            catch (Exception ex)
            {
                exceptionThrown = true;
                Assert.AreEqual("Invalid input: 'a' is not a number.", ex.Message);
            }

            Assert.IsTrue(exceptionThrown, "Expected exception was not thrown.");
        }
    }
}
