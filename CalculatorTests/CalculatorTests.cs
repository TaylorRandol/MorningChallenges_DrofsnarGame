using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sept21st;
using System;

namespace CalculatorTests
{
    [TestClass]
    public class CalculatorTests
    {
        //first thing new it up
        //create a field that is basically an ACTUAL CALCULATOR for us to use
        private Calculator calculator = new Calculator();

        [TestMethod]
        public void AddMethods()
        {
            double expectedResult = calculator.Add(1, 2);
            double actualResult = 1 + 2;
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void SubtractMethods()
        {
            double expectedResult = calculator.Subtract(1, 2);
            double actualResult = 1 - 2;
            Assert.AreEqual(expectedResult, actualResult);
            
        }

        [TestMethod]
        public void MultiplyMethods()
            {
            double expectedResult = calculator.Multiply(1, 2);
            double actualResult = 1 * 2;
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void DivideMethods()
        {
            double expectedResult = calculator.Divide(1, 2);
            double actualResult = 1d/2;
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestDifference_DoubleArrayOverload_ShouldAssertExpectedAndActualAreEqual()
        {
            double expected = 100d - 50d - 40d;
            double actual = calculator.Difference(100d, 50d, 40d);
            Assert.AreEqual(expected, actual);
        }
    }
}
