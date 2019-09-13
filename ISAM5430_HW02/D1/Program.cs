using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the count of numbers");
            int count = Convert.ToInt32(Console.ReadLine()); //this number is the Control var as it is not going to change for this batch of numbers

            int n;
            int i = 0;
            int posnum = 0;
            int negnum = 0;
            
            //for (int i = 0; i < count; i++)
            //here i is the control variable 
            //we check the input given by user if its less than the givent count number. if it exceeds the count then it exits loop
            while(i<count)
            {
                Console.WriteLine("enter numbers");
                n = Convert.ToInt32(Console.ReadLine());
                if (n > 0)
                {
                    Console.WriteLine("It is a positive number");
                     posnum++; 
                    
                }
                else
                {
                    Console.WriteLine("It is a negative number");
                    negnum++;
                }
                
                i++;

            }
            Console.WriteLine("the count of positive numbers is :");
            Console.WriteLine(posnum);
            Console.WriteLine("the count of negative numbers is :");
            Console.WriteLine(negnum);

        }
    }
}
