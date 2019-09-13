using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C1_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 1;
            while(num<=20)
            {
                if(num%2==1 && num%3!=0)
                { 
                    
                        Console.WriteLine(num);

                    



                }
                
                num++;
            }
        }
    }
}
