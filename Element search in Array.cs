
//Searches element in array.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Class8
    {
        int final1;
        int ans;
        int flag = 1;


        public int solution(int[] A)
            {
                
                Array.Sort(A);
                final1 = linearsearch(A);


            return final1;
            }
        public int linearsearch(int[] A)
        {
            int first = A[0];

            if(first < 0)
            {
                ans = 1;
            }
            else
            {
                foreach (int i in A)
                {

                    if (i == first)
                    {
                        //first += 1;
                        continue;
                    }
                    else if (i < first)
                    {
                    }
                    else if (i > first)
                    {
                        first = first + 1;
                        if (i == first)
                        {
                            continue;
                        }
                        else
                        {

                            ans = first;
                            flag = 0;
                        }

                    }
                }

            }
        if(flag == 1)
            {
                ans = A[A.Length - 1] + 1;
            }
        return ans;

        }
        public static void Main(string[] args)
        {
            //Your code goes here
            Class8 p = new Class8();
            int[] A = {-1,-3};
            p.solution(A);
        }
    }
   
}
    
    

