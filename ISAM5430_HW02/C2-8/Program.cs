using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C2_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 1;
            WriteLine(n);
            while (n<100)
            {
                //intially the value of n is 1
                //then once you have value of n then you multiply it by 2
                

                n = n * 2;
                WriteLine(n);

            }
         ;
        }
    }
}
