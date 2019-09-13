using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C1_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 1;
            while(num<=100)
            {
                if(num%3!=0 && num%5!=0||(num%3==0&&num%5==0) )
                {
                    WriteLine(num);
                }
                num++;
            }
        }
    }
}
