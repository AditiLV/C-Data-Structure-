// if given element is in array or not.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Program2
    {
        int result;
        int result1;

        bool flag = true;
        public int solution(int X, int[] A)
        {
            // write your code in Java SE 8
            int[] xarr = Enumerable.Range(1, X).ToArray();
            int[] B = A.Distinct().ToArray();
            HashSet<int> hash1 = new HashSet<int>(B);
            foreach (var s in xarr)
            {
                if (!hash1.Contains(s))
                {
                    result1 = 0;
                    flag = false;

                }
            }
            Console.WriteLine(flag);

            if (flag != false)
            {
                int index1 = Array.IndexOf(B, X);
                int index2 = Array.IndexOf(A, X);
                if (index1 <= index2)
                {
                    result = index2;
                    flag = true;
                }
                Console.WriteLine(flag);

            }

            Console.WriteLine(flag ? result : result1);
            return flag ? result : result1;

        }
        public static void Main(string[] args)
        {
            Program2 p = new Program2();
            int[] A = { 1, 2, 3,4,5,6, 7, 8 };
            p.solution(6, A);
            //Your code goes here
            Console.WriteLine("Hello, world!");
        }
    }
}
