using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D1_6
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Enter the count");
            int count = Convert.ToInt32(ReadLine());
            int i = 0;
            int min = 0;
            int n;
            WriteLine("Enter the count");
            while(i<count)
            {
                n = Convert.ToInt32(ReadLine());
                if(n<min)
                {
                    min= n;
                }
                i++;
            }
            WriteLine("The smallest number is :");
            WriteLine(min);
            
        }
        
    }
}
