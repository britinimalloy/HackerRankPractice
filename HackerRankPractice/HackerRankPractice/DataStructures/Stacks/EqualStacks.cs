using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankPractice.DataStructures.Stacks
{
    class EqualStacks
    {
        /// <summary>
        /// This method uses the code supplied by hackerrank's main function
        /// </summary>
        public void DoSomething()
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            string[] n1N2N3 = Console.ReadLine().Split(' ');

            int n1 = Convert.ToInt32(n1N2N3[0]);

            int n2 = Convert.ToInt32(n1N2N3[1]);

            int n3 = Convert.ToInt32(n1N2N3[2]);

            int[] h1 = Array.ConvertAll(Console.ReadLine().Split(' '), h1Temp => Convert.ToInt32(h1Temp));

            int[] h2 = Array.ConvertAll(Console.ReadLine().Split(' '), h2Temp => Convert.ToInt32(h2Temp));

            int[] h3 = Array.ConvertAll(Console.ReadLine().Split(' '), h3Temp => Convert.ToInt32(h3Temp));

            int result = equalStacks(h1, h2, h3);

            //textWriter.WriteLine(result);
            Console.WriteLine(result);

            //textWriter.Flush();
            //textWriter.Close();
        }


        /// <summary>
        /// You have three stacks of cylinders where each cylinder has the same diameter, but they may vary in height. You can change the height of a stack by removing and discarding its topmost cylinder any number of times.
        /// Find the maximum possible height of the stacks such that all of the stacks are exactly the same height.This means you must remove zero or more cylinders from the top of zero or more of the three stacks until they're all the same height, then print the height. The removals must be performed in such a way as to maximize the height.
        /// Note: An empty stack is still a stack.
        /// Input Format:
        ///     - The first line contains three space-separated integers, n1, n2, and n3, describing the respective number of cylinders in stacks 1, 2, and 3. The subsequent lines describe the respective heights of each cylinder in a stack from top to bottom:
        ///         - The second line contains n1 space-separated integers describing the cylinder heights in stack 1.
        ///         - The third line contains n2 space-separated integers describing the cylinder heights in stack 2. 
        ///         - The fourth line contains n3 space-separated integers describing the cylinder heights in stack 3. 
        /// Constraints:
        ///     - 0 less than n1, n2, n3 less than or equal to 100,000
        ///     - 0 less than height of any cylinder less than or equal to 100
        /// Output Format:
        ///     - Print a single integer denoting the maximum height at which all stacks will be of equal height.
        /// Sample Input:
        ///     - 5 3 4
        ///     - 3 2 1 1 1
        ///     - 4 3 2
        ///     - 1 1 4 1
        /// Sample Output:
        ///     - 5
        /// Explanation:
        ///     - Initially, the stacks look like this:
        ///     - Observe that the three stacks are not all the same height.To make all stacks of equal height, we remove the first cylinder from stacks 1 and 2, and then remove the top two cylinders from stack 3(shown below).
        ///     - As a result, the stacks undergo the following change in height:
        ///         - 1. 8-3=5
        ///         - 2. 9-4=5
        ///         - 3. 7-1-1=5
        /// All three stacks now have height = 5.Thus, we print 5 as our answer.
        /// </summary>
        /// <param name="h1">Stack # 1's cylinders' heights</param>
        /// <param name="h2">Stack # 2's cylinders' heights</param>
        /// <param name="h3">Stack # 3's cylinders' heights</param>
        /// <returns></returns>
        static int equalStacks(int[] h1, int[] h2, int[] h3)
        {
            int num = 0;
            int highestStack = 0;

            Stack<int> stack1 = ArrayToStack(h1);
            Stack<int> stack2 = ArrayToStack(h2);
            Stack<int> stack3 = ArrayToStack(h3);

            int h1height = GetStackHeight(stack1);
            int h2height = GetStackHeight(stack2);
            int h3height = GetStackHeight(stack3);

            bool areEqual = AreHeightsEqual(h1height, h2height, h3height);

            if (!areEqual)
            {
                while (!areEqual)
                {
                    highestStack = GetHighest(h1height, h2height, h3height);

                    if (highestStack == h1height)
                    {
                        PopToEven(stack1);
                        h1height = GetStackHeight(stack1);
                    }
                    else if (highestStack == h2height)
                    {
                        PopToEven(stack2);
                        h2height = GetStackHeight(stack2);
                    }
                    else
                    {
                        PopToEven(stack3);
                        h3height = GetStackHeight(stack3);
                    }
                    areEqual = AreHeightsEqual(h1height, h2height, h3height);
                }
                return h1height;
            }
            else
            {
                return h1height;
            }
        }

        static int GetStackHeight(Stack<int> stack)
        {
            int total = 0;
            foreach (int number in stack)
            {
                total += number;
            }
            return total;
        }

        static bool AreHeightsEqual(int height1, int height2, int height3)
        {
            if (height1 == height2 && height2 == height3)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static void PopToEven(Stack<int> stack)
        {
            stack.Pop();
        }

        static int GetHighest(int height1, int height2, int height3)
        {
            return Math.Max(height1, Math.Max(height2, height3));
        }

        static Stack<int> ArrayToStack(int[] stack)
        {
            stack = ReverseTheArray(stack);
            Stack<int> s = new Stack<int>();
            foreach (int number in stack)
            {
                s.Push(number);
            }
            return s;
        }
        public static int[] ReverseTheArray(int[] a)
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
