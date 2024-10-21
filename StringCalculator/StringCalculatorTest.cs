namespace TDDProject
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Return0WhenReciveEmpty()
        {
            var calculator = new StringCalculator();
            var result = calculator.Add("");
            Assert.AreEqual(0, result);
        }

        [Test]

        public void ReturnNumberWhenRecivesTheNumber()
        {
            var calculator = new StringCalculator();
            var result = calculator.Add("1");
            Assert.AreEqual(1, result);
        }

        [Test]

        public void ReturnSumWhenRecivesTwoNumbers()
        {
            var calculator = new StringCalculator();
            var result = calculator.Add("1,2");
            Assert.AreEqual(3, result);
        }

        [Test]

        public void ReturnSumWhenRecivesSeveralNumbers()
        {
            var calculator = new StringCalculator();
            var result = calculator.Add("1,2,3,4");
            Assert.AreEqual(10, result);
        }


    }
}