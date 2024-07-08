using Microsoft.VisualStudio.TestTools.UnitTesting;
using TWOSsum;

namespace TestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
        }
        [TestMethod]
        public void CalculatorNullTest()
        {
            var calculator = new Calculator();
            Assert.IsNotNull(calculator);
            Assert.IsTrue(false); // Will fail the test
        }
    }
}