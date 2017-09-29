//finds the missing elemnts in the array
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Class7
    {
        public int solution(int[] A)
        {
            // write your code in Java SE 8
            //Array.Sort(A);
            int sum = A.Sum();
            //int sum1 = ((A.Length - 1) * (A.Length - 2))/(A.Sum());
            int startId = A[0];
            double len = A.Length;
            Double sum1 = (Math.Pow(len, 2) + (2 * len) + 2) / 2;
            int final = sum ^ Convert.ToInt32(sum1);

            return 1;

        }
        public static void Main(string[] args)
        {
            Class7 c = new Class7();
			 int[] A = {-1,-3};
            c.solution(A);

        }
    }
}
