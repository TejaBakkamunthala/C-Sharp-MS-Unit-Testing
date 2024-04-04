using Microsoft.VisualStudio.TestTools.UnitTesting;
using MSUnitTestCalculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSUnitTestCalculator.Tests
{

    [TestClass()]
    public class Arrayss1Tests
    {
        Arrayss1 ar1 = new Arrayss1();
        [TestMethod()]
        public void ArraySumTest()
        {
            int result = ar1.ArraySum();
            int expected = 15;
            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void ArraySumTest2()
        {
            int result = ar1.ArraySum();
            int expected = 20;
            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void EvenSum1()
        {
            int result = ar1.SumOfEven();
            int expected = 12;
            Assert.AreEqual(expected, result);
        }


        [TestMethod()]
        public void EvenSum2()
        {
            int result=ar1.SumOfEven();
            int expecte = 15;
            Assert.AreEqual(expecte, result);
        }
    
    }
}