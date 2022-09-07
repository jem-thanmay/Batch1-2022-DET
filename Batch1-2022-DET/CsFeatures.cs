//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Batch1_2022_DET
//{
//    internal class CsFeature
//    {
//        public static void Main()
//        {
//            Action<String> action = (string name) => { Console.WriteLine($"Hai {name}"); };
//            action.Invoke("Mary");

//            Action<string, string> action1 = (string s1, string s2) => { Console.WriteLine($"Hello {s1}" + $"{s2}"); };
//            action.Invoke("Dhanush");
//            action.Invoke("Rahul");

//            Func<int, int, long> add = (x, y) =>
//            {
//                return x + y;


//            };
//            long result = add(5, 5);
//            Console.WriteLine(result);
//        }


//    }
//}
