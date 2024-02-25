using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using WeightCalculator;

namespace WeightCalculatorTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            WeightCalculation weightCalculationForFemale = new WeightCalculation
            {
                Height = 162,
                Gender = 'f'
            };
        }
    }
}
