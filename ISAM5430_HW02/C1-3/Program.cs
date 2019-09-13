using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 1;
            while(num<100)
            {
                if(num%10==0)
                {
                    Console.WriteLine(num);
                }
                num++;
            }
        }
    }
}
