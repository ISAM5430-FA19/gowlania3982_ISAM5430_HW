using System;
using static System.Console;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D1_5
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Enter the count");
            int count = Convert.ToInt32(ReadLine());
            int largest = 0;
            //int prev = 0;
            int i = 0;
            int n;
            WriteLine("enter the integers");
            while(i<count)
            {
                n = Convert.ToInt32(ReadLine());
               
                if(n>largest)
                {
                   // prev = n;
                    largest = n;
                    
                }
               
            
            i++;
        }
            WriteLine("largest number is");
            WriteLine(largest);
        }
    }
}
