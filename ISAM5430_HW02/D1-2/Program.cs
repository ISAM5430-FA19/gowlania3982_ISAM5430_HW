using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Enter the count");
            int count = Convert.ToInt32(Console.ReadLine());
            int n;
            int i = 0;
            //this is counter var for zero which counts zeros
            int zerocount = 0;
            //counter var for all numbers except zero
            int nonzero = 0;
               while(i<count)
            {
                Console.WriteLine("enter numbers");
                n = Convert.ToInt32(Console.ReadLine());
                if(n==0)
                {
                    WriteLine("it is a zero");
                        zerocount++;
                }
                else
                {
                    WriteLine("not a zero");
                    nonzero++;
                }
                i++;
            }
            WriteLine("The count of zeros is :");
            WriteLine(zerocount);
            WriteLine("count of non zero is:");
            WriteLine(nonzero);
                

        }
    }
}
