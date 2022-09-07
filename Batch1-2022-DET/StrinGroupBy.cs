//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Batch1_2022_DET
//{
//    internal class StrinGroupBy
//    {
//        public static void Main()
//        {
//            List<string> words = new List<string> { "basket", "blueberry", "chimpanze", "abacus", "banana", "appple", "cheese" };

//            var wordGroups = words.GroupBy(x => x[0]).Select
//                (y => new { FirstLetter = y.Key, Words = y });

//            foreach (var item in wordGroups)
//            {
//                Console.WriteLine("Words that start with the " + "letter '{0}':", item.FirstLetter);

//                foreach (var w in item.Words)
//                {
//                    var names2 = w.OrderByDescending(x => w.Length);
//                    Console.WriteLine(names2);
//                }

//            }
//        }
//    }
//}
