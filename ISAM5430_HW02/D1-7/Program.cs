using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D1_7
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Enter the count");
            int count = Convert.ToInt32(ReadLine());
            int i = 0;
            int n;
            int mid = count/2;
            int sum1 = 0;
            int sum2 = 0;
            Boolean a = false;
            WriteLine("enter the integers");
            while(i<count)
            {
                

                n = Convert.ToInt32(ReadLine());
                //if the count is even 
                if(count%2==0)
                {
                    if(i<mid)
                    {
                        sum1 = sum1 + n;
                    }
                    if(i>=mid)
                    {
                        sum2 = sum2 + n;
                    }

                }
                //if the count is odd
                if(count%2==1)
                {
                    if(i<mid)
                    {
                        sum1= sum1 + n;

                    }
                    if(i>mid)
                    {
                        sum2 = sum2 + n;
                    }
                }
                i++;
              
            }
            if (sum1 == sum2)
            {
                WriteLine("YES");
            }

        }
    }
}
