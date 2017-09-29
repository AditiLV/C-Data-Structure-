//Rextester.Program.Main is the entry point for your code. Don't change it.
//Compiler version 4.0.30319.17929 for Microsoft (R) .NET Framework 4.5

//Code swaps any two random numbers from array and it checks whether  it array is sorted or not, if sorted it returns 1 or else 0.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Rextester
{
    public class Program
    {Random rnd = new Random();

        int result;
        bool flag = false;
        public int solution(int[] A)
        {
            bool firstsort = isSorted(A);
            if (firstsort == true)
            {
                result = 1;
                flag = true;
            }
            if (flag == false)
            {
                int[] Arr = swap(A);
                bool secondsort = isSorted(A);
                if (secondsort == true)
                {
                    result = 1;
                    flag = true;
                }
                else
                {
                    result = 0;
                    flag = false;
                }
               
            }
            foreach (int i in A){
                            Console.WriteLine(i);

            }
            return result;
        }
        public int[] swap(int[] data)
        {
            int random = rnd.Next(0, data.Length);
            int random1 = rnd.Next(0, data.Length);
            if (random != random1)
            {
                int temp = data[random];
                data[random] = data[random1];
                data[random1] = temp;
                return data;
            }
            else
            {
                swap(data);
                return null;
            }
            
        }

        
        public bool isSorted(int[] data)
        {
            for (int i = 1; i < data.Length; i++)
            {
                if (data[i - 1] > data[i])
                {
                    return false;
                }
            }
            return true;
        }
    
    
        public static void Main(string[] args)
        {
            //Your code goes here
            int [] A = {6,1,4,5};
            int first = 1;
            int second = 9;
            Program p = new Program();
            int a =p.solution(A);
            Console.WriteLine(a);
            
        }
    }

    }
