using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Enter the count");
            String count = ReadLine();
            int c = Convert.ToInt32(count);
            int n;
           // WriteLine("Enter the {0} integers", c);
            for (int i = 0; i < c; i++)
            {


                WriteLine("Enter the {0} integers", c);
                n = Convert.ToInt32(ReadLine());
                if (n > 0)
                {
                    WriteLine("positive numbers {0}",c);
                    
                    
                }
                
            }


        }
    }
}
