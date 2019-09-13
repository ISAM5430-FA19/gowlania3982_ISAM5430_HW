using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D1_4
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Enter the count");
            int count = Convert.ToInt32(ReadLine());
            int n = 0;
            int prevnum = 0;
            int i = 0;
            WriteLine("Enter the integers");

            while (i<count)
            {
                n = Convert.ToInt32(ReadLine());
                if(i==0)
                {
                    prevnum = n;
                }
                else if(n<prevnum)
                {
                    WriteLine("Enter the numbers in increasing order");
                    break;
                }
                else
                {
                    prevnum = n;
                }
                
                i++;
            }
           
                

        }
    }
}
