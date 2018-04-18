using System;
using HackerRankPractice.DataStructures.Arrays;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankPractice
{
    class Solutions
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, welcome to my app!");

            // call the method from here
            ReverseArray reverseArray = new ReverseArray();
            reverseArray.GetInput();

            Console.WriteLine("Press any key to Exit");            
            Console.ReadKey(true); // Close program
        }
    }
}

        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Hello, welcome to my app!");

        //    ReverseArray reverseArray = new ReverseArray();
        //    reverseArray.GetInput();

        //    Console.WriteLine("Press any key to Exit");
        //    Console.ReadKey(true); // Close program
        //}
