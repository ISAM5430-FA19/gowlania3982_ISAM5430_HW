using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C4
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            decimal avg = 0;
            //int n;
            WriteLine("Enter the count");
            String count = ReadLine();
            int c = Convert.ToInt32(count);
            for(int i=0;i<c;i++)
            {
                int n;
                
                WriteLine("Enter the integers");
                n =Convert.ToInt32(ReadLine());
                sum = sum + n;
                avg = sum / n;


            }
            WriteLine("The sum is");
            WriteLine(sum);
            
            WriteLine(avg);

        }
    }
}
