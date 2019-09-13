using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C1_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 1;
            while (n < 10)
            {
                int square;
                square = n * n;
                int count = 0;
                int q = square;
                n++;
                while (q!=0)
                {
                    q = q / 10;
                    count++;
                }
                if(count == 2)
                {
                    Console.WriteLine(square);

                }
            }
        }
    }
}
