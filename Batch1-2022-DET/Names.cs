//using System;
//using System.Collections.Generic;
//using System.Diagnostics;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Batch1_2022_DET
//{
//    internal class Names
//    {
//        public static void Main()
//        {
//            DataSource();
//        }
//        static void DataSource()
//        {
//            //string[] words1 = { "believe", "relief", "receipt", "field" };

//            //var outcome = from word in words1
//            //select word;

//            string[] Names = { "John", "Peter", "Jakob", "Harry","Jackson" };
//            var outcome = from name in Names
//                          where name.Contains("o")
//                          select name;

//            //foreach (var word in outcome)
//                //Console.WriteLine($"{word}--{word.Length}");

//            foreach (var name in outcome)
//                Console.WriteLine(name);

//            //Console.WriteLine(outcome);
//        }
//    }
//}
