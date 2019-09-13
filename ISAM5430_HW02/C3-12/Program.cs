using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C3_12
{
    class Program
    {
        static void Main(string[] args)
        {
            int currentnum = 1;
            int oldnum = 0;
            WriteLine(oldnum);
            WriteLine(currentnum);
            int nextnum;
            //WriteLine(num);
            //int prev = 0;
            int i = 2;
            while(i < 25)
            {
                nextnum = currentnum + oldnum;
                oldnum = currentnum;
                currentnum = nextnum;

               
               
                WriteLine(nextnum);
                i++;
            }
           

        }
    }
}
