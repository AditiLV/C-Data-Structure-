//Rextester.Program.Main is the entry point for your code. Don't change it.
//Compiler version 4.0.30319.17929 for Microsoft (R) .NET Framework 4.5

////Input is a row of days a traveller wants to travel, based on the sequence of the days programs generates 
//a minimum amount that traveller has to pay. Tickets cost are : 1days = 2 bucks, 7 days = 7 bucks, 30 days = 25 bucks.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Rextester
{
    public class Program
    {
    int result;
        public int solution(int[] A)
        {
            if (A.Length > 30 || A.Length < 1)
            {
                return -1;
            }
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            if(A.Length >= 23)
            {
                result = 25;
            }
            if(A.Length <= 3)
            {
                result = (A.Length * 2);
            }
            if(A.Length < 23 || A.Length > 3)
            {
                result = Math.Min(countdays(A, 1, A[0] + 6) + 7, countdays(A, 1, 0) + 2);
                Console.WriteLine(result);
            }
            return result;
        }
        public static int countdays(int[] A, int index, int max)
        {
            if (index >= A.Length)
            {
                return 0;
            }
            if (A[index] <= max)
            {
                return countdays(A, index + 1, max);
            }
            else
            {
                return (Math.Min(countdays(A, index + 1, A[index] + 6) + 7, countdays(A, index + 1, 0) + 2));
            }
        }
        public static void Main(string[] args)
        {
            int[] A = {1, 2, 4, 5, 7, 29, 30};
            Program p = new Program();
           p.solution(A);
        }
    }
}