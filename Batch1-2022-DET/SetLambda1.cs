using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_2022_DET
{
    internal class SetLambda1
    {
        public static void Main()
        {
            SetExamples();
        }
        static void SetExamples()
        {
            int[] num = { 11, 12, 12, 13, 15, 16, 17, 18, 19, 19, 20 };

            var outcome = num.Distinct();                // 1.Distinct
            
            //int[] num1 = { 1, 2, 3, 4, 5, 6};
           // int[] num2 = { 2, 3, 4, 7, 8};

            //var outcome = num1.Except(num2);
            // var outcome = num2.Except(num1);               //2. Except

            //var outcome = num1.Intersect(num2);             //3.Intersect

           // var outcome = num1.Union(num2);                  //4. Union   


            foreach (int value in outcome)
                Console.WriteLine(value);
        }
    }
}
