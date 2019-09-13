using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 1;
            while(num<=10)
            {
                if (num % 2 == 0)
                {
                    WriteLine(num);
                    
                }
                num++;
                
            }
        }
    }
}
