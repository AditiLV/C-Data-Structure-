//Program that prints possible square roots of numbers between range, eg in between 1 to 10 it will print 1,4,9.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Rextester
{
    public class Program
    {
        int c;
        public void solution(int first,int second) {
        
            int cnt = 0;
            int i;
            for(i = first;i<=second;i++){
                if(Math.Sqrt(Convert.ToDouble(i)) % 1 == 0){
                    Console.WriteLine(i);
                    cnt += 1;
                    
                
                }
            
            }
         Console.WriteLine(cnt);
        }
                  
    
        public static void Main(string[] args)
        {
            //Your code goes here
            int first = 1;
            int second = 9;
            Program p = new Program();
            p.solution(first,second);
            Console.WriteLine("Hello, world!");
            
        }
    }

    }
