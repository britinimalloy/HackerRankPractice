using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankPractice.DataStructures.Arrays
{
    class ArrayManipulation
    {
        /// <summary>
        /// This method uses the code suplied by hackerrank's main function
        /// </summary>
        public void DoSomething()
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            string[] nm = Console.ReadLine().Split(' ');

            int n = Convert.ToInt32(nm[0]);

            int m = Convert.ToInt32(nm[1]);

            int[][] queries = new int[m][];

            for (int queriesRowItr = 0; queriesRowItr < m; queriesRowItr++)
            {
                queries[queriesRowItr] = Array.ConvertAll(Console.ReadLine().Split(' '), queriesTemp => Convert.ToInt32(queriesTemp));
            }

            int result = arrayManipulation(n, queries);

            Console.WriteLine(result); //textWriter.WriteLine(result);

            //textWriter.Flush();
            //textWriter.Close();
        }

        /// <summary>
        /// You are given a list(1-indexed) of size n, initialized with zeroes.You have to perform m operations on the list and output the maximum of final values of all the n elements in the list.For every operation, you are given three integers a, b and k and you have to add value k to all the elements ranging from index a to b (both inclusive). 
        /// For example, consider a list a of size 3.The initial list would be a = [0,0,0] and after performing the update 0(a,b,k) = (2,3,30), the new list would be a = [0,30,30]. Here, we've added value 30 to elements between indices 2 and 3. Note the index of the list starts from 1.
        /// 
        /// Input Format:
        ///     - The first line will contain two integers n and m separated by a single space.
        ///     - Next, m lines will contain three integers a,b and k separated by a single space.
        ///     - Numbers in list are numbered from 1 to n.
        /// 
        /// Constraints:
        ///     - 3 less than or equal to n less than or equal to (10 to the 7th)
        ///     - 1 less than or equal to m less than or equal to (2 * (10 to the 5th))
        ///     - 1 less than or equal to a less than or equal to b less than or equal to n
        ///     - 0 less than or equal to k less than or equal to (10 to the 9th)
        /// Output Format;
        ///     Print in a single line the maximum value in the updated list.
        /// Sample Input:
        ///     5 3
        ///     1 2 100
        ///     2 5 100
        ///     3 4 100
        /// Sample Output:
        ///     200
        /// Explanation:
        ///     - After first update list will be 100 100 0 0 0. 
        ///     - After second update list will be 100 200 100 100 100.
        ///     - After third update list will be 100 200 200 200 100.
        ///     - So the required answer will be 200.
        /// </summary>
        /// <param name="n"></param>
        /// <param name="queries"></param>
        /// <returns></returns>
        public int arrayManipulation(int n, int[][] queries)
        {
            int someNumber = 0;

            return someNumber;
        }
    }
}
