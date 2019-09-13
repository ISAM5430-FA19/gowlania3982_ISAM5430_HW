using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B2
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("enter a");
            int a = Convert.ToInt32(ReadLine());
            WriteLine("enter b");
            int b = Convert.ToInt32(ReadLine());
            WriteLine("enter c");
            int c = Convert.ToInt32(ReadLine());
            //condition to check if a is middle number
            if(a>b&&a<c || a<b&&a>c)
            {
                WriteLine("a is the  middle number");
            }
            else if(b>a&&b<c || b<a&&b>c)
            {
                WriteLine("b is the middle number" );
            }
            else
            {
                WriteLine("c is the middle number ");
            }

        }
    }
}
