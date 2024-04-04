using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSUnitTestCalculator
{
    public class Arrayss1
    {

        public int ArraySum()
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {

                sum = sum + arr[i];
            }
            return sum;
        }
    


    public int SumOfEven()
    {
        int[] arr = { 1, 2, 3, 4, 5, 6 };
        int evenSum = 0;
        for(int i = 0; i < arr.Length; i++)
        {
            if (arr[i] % 2 == 0)
            {
                evenSum = evenSum + arr[i];
            }
        }
        return evenSum;
    }

}
}
