using System;
using static System.Console;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C2_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 100;
            WriteLine(n);
            while(n>=1)
            {
                n = n /2;

                WriteLine(n);
            }
        }
    }
}
