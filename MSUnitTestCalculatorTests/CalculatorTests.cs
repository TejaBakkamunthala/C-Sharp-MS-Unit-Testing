using Microsoft.VisualStudio.TestTools.UnitTesting;
using MSUnitTestCalculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace MSUnitTestCalculator.Tests
{
    [TestClass()]
    public class CalculatorTests
    {
        Calculator C1=new Calculator();
        [TestMethod()]
        public void AddTest()
        {
            int result = C1.Add(10, 20);
            int expected = 30;
            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void AddTest1()
        {
            int result = C1.Add1(20, 30);
            int expected = 50;
            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void SubTest()
        {
            int result=C1.Sub(30, 20);
            int expected = 10;
            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void SubTest1()
        {
            int result=C1.Sub(40, 20);
            int expected = 10;
            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void MulTest()
        {
            int result = C1.Mul1(10, 10);
            int expected = 100;
            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void MulTest1()
        {
            int result=C1.Mul1(20, 10);
            int expected = 300;
            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void Div()
        {
            int result=C1.Div1(20,10);
            int expected = 2;
            Assert.AreEqual(expected, result);
        }


        [TestMethod()]
        public void Div1()
        {
            int result = C1.Div1(40, 10);
            int expected = 4;
            Assert.AreEqual(expected, result);
        }

    }
}