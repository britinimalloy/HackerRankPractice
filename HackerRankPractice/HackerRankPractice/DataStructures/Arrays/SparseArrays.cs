using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankPractice.DataStructures.Arrays
{
    class SparseArrays
    {
        /// <summary>
        /// This method uses the code suplied by hackerrank's main function
        /// </summary>
        public void DoSomething()
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int stringsCount = Convert.ToInt32(Console.ReadLine());

            string[] strings = new string[stringsCount];

            for (int stringsItr = 0; stringsItr < stringsCount; stringsItr++)
            {
                string stringsItem = Console.ReadLine();
                strings[stringsItr] = stringsItem;
            }

            int q = Convert.ToInt32(Console.ReadLine());

            for (int qItr = 0; qItr < q; qItr++)
            {
                string queryString = Console.ReadLine();

                int res = findSuffix(strings, queryString);

                Console.WriteLine(res);//textWriter.WriteLine(res);
            }

            //textWriter.Flush();
            //textWriter.Close();
        }

        /// <summary>
        /// Instructions per hackerrank: 
        /// There is a collection of N strings(There can be multiple occurences of a particular string ). Each string's length is no more than 20 characters.There are also Q queries. For each query, you are given a string, and you need to find out how many times this string occurs in the given collection of N strings.
        ///     Input Format:
        ///         - The first line contains N, the number of strings.
        ///         - The next N lines each contain a string.
        ///         - The N + 2nd line contains Q, the number of queries.
        ///         - The following Q lines each contain a query string.
        ///     Constraints:
        ///         - 1 less than or equal to N less than or equal to 1000
        ///         - 1 less than or equal to Q less than or equal to 1000
        ///         - 1 less than or equal to length of any string less than or equal to 20
        ///     Sample input:
        ///         4
        ///         aba
        ///         baba
        ///         aba
        ///         xzxb
        ///         3
        ///         aba
        ///         xzxb
        ///         ab
        ///     Sample output:
        ///         2
        ///         1
        ///         0
        ///     Explanation:
        ///         - Here, "aba" occurs twice, in the first and third string. The string "xzxb" occurs once in the fourth string, and "ab" does not occur at all.
        /// My plan to solve it:
        ///     - using findSuffix, loop through collections and record how many times queryString is found 
        /// </summary>
        public int findSuffix(string[] collections, string queryString)
        {
            int numOfTimes = 0;
            for (int ii = 0; ii < collections.Length; ii++)
            {
                if (queryString == collections[ii])
                {
                    numOfTimes++;
                }
            }

            return numOfTimes;
        }
    }
}
