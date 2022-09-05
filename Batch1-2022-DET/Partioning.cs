using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_2022_DET
{
    internal class Partioning
    {
        public static void Main()
        {
            SkipUsingLambda();
            
        }
        static void SkipUsingLambda()
        {
            string[] words = { "sky", "butterfly", "honey", "pebbles", "moon", "sun", "planets", "universe" };
            //var outcome = words.Skip(3);

            //var outcome = words.SkipWhile(w => w.Length == 4);

            //var outcome = words.Take(3);
            int[] num = { 12,14,16,18,20 };

            var outcome = num.TakeWhile(n => n < 20);

            foreach (int numb in outcome)

                //Console.WriteLine("Skips the first 3 words:");

                Console.WriteLine(numb);

            //foreach (string word in outcome)
            //    //Console.WriteLine("Skips the first 3 words:");

            //    Console.WriteLine(word);
        }
    }
}
