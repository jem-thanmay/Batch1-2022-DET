//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Batch1_2022_DET
//{
//    internal class GroupByExample
//    {
//        public static void Main()
//        {
//            GroupByEx();

//        }
//        static void GroupByEx()
//        {
//            List<string> words = new List<string> { "basket", "ball", "blackberry", "cherry", "chocolate", "apple", "amazon", "deer", "zimbabve", "zebra", "yolk" };
//            var word = from n in words
//                       group n by n into g
//                       select new { NumOfLetters = g.Key, Words = g };
//            var wordGroups = words.GroupBy(x => x.Length).Select
//                (y => new { NumOfLetters = y.Key, Words = y });

//            foreach (var item in wordGroups)
//            {
//                Console.WriteLine("{0} :", item.NumOfLetters);
//                foreach (var w in item.Words)
//                {
//                    Console.WriteLine(w);
//                }
//            }

//        }
//    }
    
//}
