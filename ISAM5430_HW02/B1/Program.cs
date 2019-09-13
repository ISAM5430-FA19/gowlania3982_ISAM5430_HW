using System;
using static System.Console; //by using this we dont have to mention console everywhere 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B1
{
    class Program
    {
        static void Main(string[] args)
        {
            //prompt to enter num1
            //input num1
            //prompt to enter num2
            //input num2
            //if num1>num2
            //print num1 is larger
            // else if num2>num1
            //print num2 is larger
            //else
            //print both are same
            WriteLine("enter num1");
            string s1 = ReadLine();
            int num1 = Convert.ToInt32(s1);
            WriteLine("enter num2");
            string s2 = ReadLine();
            int num2 = Convert.ToInt32(s2);
            if(num1>num2)
            {
                WriteLine("num1 is larger");
            }
            else if (num2 > num1)
            {
                WriteLine("num2 is larger");
            }
            else
            {
                WriteLine("both are same");
            }




        }
    }
}
