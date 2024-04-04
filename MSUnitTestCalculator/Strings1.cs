using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSUnitTestCalculator
{
    public class Strings1
    {

        public String AddString1(string str1,String str2)
        {
            return str1 + str2;
        }

        public String ReverseString1(String str1)
        {
            String reverse= "";
            for(int i = str1.Length - 1; i >= 0; i--)
            {
                reverse = reverse + str1[i];
            }
          
            return reverse;
        }

       

    }
}
