using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Enter the count");
            int count = Convert.ToInt32(ReadLine());
            int n;
            int i=0;
            int evencount = 0;
            while(i<count)
            {
                WriteLine("enter the integers");
                 n = Convert.ToInt32(ReadLine());
                if(n%2==0)
                {
                    WriteLine("it is a even integer");
                    evencount++;
                }
                else
                {
                    WriteLine("Not even");
                    
                }
                i++;
               
            }
            WriteLine("The count of even integers is:");
            WriteLine(evencount);
        }
    }
}
