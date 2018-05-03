using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankPractice.DataStructures.Stacks
{
    public class Solution
    {
        private int[] OpTypeValues = new[] { 1, 2, 3 };
        private static Stack<int> _numberStack = new Stack<int>();
        public void DoSomethingMain(String[] args)
        {
            int count = 0;
            int numOfQueries = GetUserQueries();

            while (count < numOfQueries)
            {
                RepeatGetOp();
                count++;
            }
        }

        public static int GetUserQueries()
        {
            int queries;
            //Console.WriteLine("Please enter a number for how many queries you want to use.");
            return queries = Convert.ToInt32(Console.ReadLine());
        }

        public static int GetTypeOfOp()
        {
            int op;
            //Console.WriteLine("Please enter the operation type, 1, 2, or 3.");
            return op = Convert.ToInt32(Console.ReadLine());
        }

        public static int GetMyNumber()
        {
            int num;
            //Console.WriteLine("Please enter the number to add to the stack.");
            return num = Convert.ToInt32(Console.ReadLine());
        }

        public static void PrintMyMaxNumber()
        {
            int max = GetMaxNumber();
            Console.WriteLine(max);
        }

        public static int GetMaxNumber()
        {
            int max = _numberStack.Max();
            return max;
        }

        public static void RepeatGetOp()
        {
            int opType;
            int myNumber;

            opType = GetTypeOfOp();

            if (opType == 1)
            {
                myNumber = GetMyNumber();
                _numberStack.Push(myNumber);
            }
            else if (opType == 2)
            {
                _numberStack.Pop();
            }
            else
            {
                PrintMyMaxNumber();
            }
        }
    }
}
