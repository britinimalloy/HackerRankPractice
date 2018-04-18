using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankPractice.DataStructures.Arrays
{
    class ReverseArray
    {
        /// <summary>
        /// This method uses the code suplied by hackerrank for its main function
        /// </summary>
        public void GetInput()
        {
            //int numOfNumbers = Convert.ToInt32(Console.ReadLine());

            int[] arrOfNum = Array.ConvertAll( Console.ReadLine().Split(' '), arrayTemp => Convert.ToInt32(arrayTemp) );

            int[] result = ReverseTheArray(arrOfNum);
            Console.WriteLine(string.Join(" ", result));
        }

        /// <summary>
        /// Instructions per haccerrank: 
        /// Given an array, A, of N integers, print each element in reverse order as a single line of space-separated integers.
        /// My plan to solve it:
        /// Since every element in the array needs to be touched, a for loop would be best. I am going to create a new array, using the length of the first to create the length for the new one, and an int to hold the number of the last element in the original array. This is to ensure I can start with the last element in the original array and I will decrement it after the value in that element has been stored in the new array. Hackerrank supplies a main where it gets the input from and takes care of displaying the array once it's been separated, so I just need to take in an int array and output an int array.
        /// </summary>
        public int[] ReverseTheArray(int[] a)
        {
            int[] aRev = new int[a.Length];
            int lastElement = a.Length - 1;

            for (int ii = 0; ii < a.Length; ii++)
            {
                aRev[ii] = a[lastElement];
                lastElement--;
            }

            return aRev;
        }
    }
}
