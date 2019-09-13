using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D1_8
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Enter the count");
            int count = Convert.ToInt32(ReadLine());
            int i = 1;
            int n;
            int clumpcount = 0;
            Boolean a = false;
            WriteLine("Enter integers :");
            n = Convert.ToInt32(ReadLine());
            int prev = 0;
            while (i<count)
            {
                prev = n;
                n = Convert.ToInt32(ReadLine());
                if(n==prev)
                {
                    if (!a)
                    {
                        a = true;
                        clumpcount++;

                    }
                }
                else
                {
                    a = false;
                }
                i++;
            }
            WriteLine(clumpcount);
        }
    }
}
