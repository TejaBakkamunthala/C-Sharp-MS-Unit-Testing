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
    public class Strings2Tests
    {
        Strings2 s2=new Strings2();
        [TestMethod()]
        public void concat1Test()
        {
            string result = s2.Concat1("Hii", "Bro");
            string expected = "HiiBro";
            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void subString1Test()
        {
            string result = s2.substring1("Teja Bakk");
            string expected = "Teja";
            Assert.AreEqual(expected, result);
      }

        [TestMethod()]
        public void subString2Test()
        {
            string result = s2.substring1("Teja Bakk");
            string expected = "Teja B";
            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void CharReplace1()
        {
            string result = s2.characterReplacement("Teja Teja");
            string expected = "Tejt Tejt";
            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void CharReplace2() {
            string result = s2.characterReplacement("Teja Teja");
            string expected = "Teja Teja";
            Assert.AreEqual(expected, result);
        
        }

        [TestMethod()]
        public void EmptStringg1()
        {
            string result = s2.EmpStr("");
            string expected = "";
            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void EmpStringg2()
        {
            string result = s2.EmpStr("");
            String expected = "hii";
            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void NullStringg1()
        {
           bool result = s2.NullStr("");
           bool expected = true;
            Assert.Equals(expected, result) ;  
        }

        [TestMethod()]
        public void NullString2()
        {
            bool result = s2.NullStr("h");
            bool expected = true;
            Assert.Equals(expected, result);
        }

        [TestMethod()]
        public void SpecialCharcater1()
        {
            string result = s2.specialCharacter("Teja");
            string expected = "true";
            Assert.AreEqual(expected, result);
        }


        [TestMethod()]
        public void SpecialCharcater2()
        {
            string result = s2.specialCharacter("Teja#$$");
            string expected = "true";
            Assert.AreEqual(expected, result);

        }



    }
}