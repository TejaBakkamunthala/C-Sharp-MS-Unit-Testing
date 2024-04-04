using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MSUnitTestCalculator
{
    public class Strings2
    {
   
        public string Concat1(String str1, String str2) 
        {
            String con = str1 + str2;
            return con;
        }



        public string substring1(string str3) {

            string sub1 = str3.Substring(0, 4);
            return sub1;
        }

        public string characterReplacement(String str4)
        {

            String charr = str4.Replace('a','t');
            return charr;
        }
        public string EmpStr(String str)
        {
            String empp = string.Empty;
            return empp;
        }

        public bool NullStr(String str)
        {
            bool nullStr = string.IsNullOrEmpty(str);

            return nullStr;

        }

        //33-47

        public string specialCharacter(String str)
        {
            char[] charr = str.ToCharArray();
            int count = 0;
            for(int i=0; i<charr.Length; i++)
            {
               
                if (charr[i] >= 33 && charr[i]<=47)
                {
                    count++;
                }
            }
            if (count > 1)
            {
                return "false";
            }
            else
            {
                return "true";
            }
        }
    }
}
