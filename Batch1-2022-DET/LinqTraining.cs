//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Batch1_2022_DET
//{
//    internal class LinqTraining
//    {
//        public static void Main()
//        {
//            //List<int> numbers = new List<int>();  //First we need to Declare the list of value which we want 
//            //numbers.Add (110);
//            //numbers.Add(150);
//            //numbers.Add(113);
//            //numbers.Add(234);

//            ////("Comment anyone of them to try out the O/p)


//            ////This is called as Early execution value added to number after this wont be displayed
//            ////var numQuery = (from num in numbers
//            ////                select num).ToList();



//            ////This is called as deffered execution value added to number after this will be diplayed 
//            ////var numQuery = from num in numbers   //It always starts with from and ends with select.
//            ////                where num > 115  
//            ////                select num; // Query creation 



//            ////Lambda query= second type of Query execu
//            //var numQuery = numbers.Where(x => x > 115); //first x is input and second x is output x should be equal to x;
//            //                                            //x is input and y is the output.



//            ////num can be of any other words "abcd" its just a pointer.
//            //numbers.Add(234);   



//            //foreach (var num in numQuery)  //To run the query we use the foreach iterator.
//            //{
//            //    Console.WriteLine($"{num}");
//            //}

//            ////OrderBy

//            //int[] NUmbers = { 5, 1, 9 };

//            //var NumbersOrdered = NUmbers.OrderBy(x => x);

//            //foreach (var NuM in NumbersOrdered)
//            //{
//            //    Console.WriteLine("{0}", NuM);
//            //}


//            ////OrderByDescending 

//            //int[] NUMbers = { 5, 1, 9 };

//            //var NumbersDescending = NUmbers.OrderByDescending(x => x);

//            //foreach (var Desc in NumbersDescending)
//            //{
//            //    Console.WriteLine(Desc);
//            //}



//            ////ThenBy
//            //    string[] capitals = { "Berlin", "Paris", "Madrid", "Tokyo", "London",
//            //              "Athens", "Beijing", "Seoul" };

//            //    var result = capitals.OrderBy(c => c.Length).ThenBy(c => c);

//            //    Debug.WriteLine("Ordered list of capitals, first by length and then alphabetical:");
//            //    foreach (string capital in result)
//            //        Debug.WriteLine(capital);



//            //LambdaSkip.Main();
//            //SkipWhile.Main();
//            //Take.take();
//            //TakeWhile1.Sample_TakeWhile_Lambda();

//            ////Aggregate.Main();
//            //Average.avg();
//            //Count.count();
//            //Max.max();
//            //Sum.sum();


//            ////Set
//            //Distinct.distinct();
//            //Except.except();
//            //Intersect.intersect();
//            //Union.union();

//            ////Elements
//            //ElementAt.elementat();
//            //ElementAtDefault.elementsatdefault();
//            //First.first();
//            //FirstCondition.firstCondition();
//            //FirstOrDefault.firstOrDefault();

//            ////Quantifier
//            //All.all();
//            //Any.any();

//            //Except.except();
//        }
//    }
//}
