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
    public class Strings1Tests
    {

        Strings1 s1=new Strings1 ();
        [TestMethod()]
        public void AddString1Test()
        {
            string result = s1.AddString1("Hii", " Teja");
            string expected = "Hii Teja";

            Assert.AreEqual (expected, result);
                
         }

        [TestMethod()]
        public void Reverse1()
        {
            String result = s1.ReverseString1("MALAYALAM");
            
            string expected = "MALAYALAM";
            Assert.AreEqual (expected, result);
        }



        [TestMethod()]
        public void Reverse2()
        {
            String result = s1.ReverseString1("TEJA");
            String expected = "TEJA";
            Assert.AreEqual(expected, result);
        }
    }
}