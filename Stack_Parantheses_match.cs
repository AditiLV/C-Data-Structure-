//Code for checking if the parentheses are   in sequential manner or not. Using stack	
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ConsoleApplication1
{
    class Class11
    {
        public int solution(string S)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            int result = 0;
            bool flag = true;
            Stack<int> stack = new Stack<int>();
            foreach (char a in S)
            {
                if (a == '(')
                {
                    stack.Push(a);
                }
                if (a == ')')
                {
                    if (stack.Count > 0)
                    {
                        stack.Pop();
                    }
                    else
                    {
                        result = 0;
                        flag = false;
                        
                    }
                }

            }
            if(stack.Count == 0 && flag == true)
            {
                result = 1;
            }
            return result;


        }
        public static void Main(string[] args)
        {
            //Your code goes here
            Class11 p = new Class11();
            p.solution("())");
            Console.WriteLine("Hello, world!");
        }
    }
}
