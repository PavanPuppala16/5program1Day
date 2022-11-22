using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5program1Day
{


    public class palendromeno
    {
        public void PalendromeNo1()
        {
            int i, n, sum = 0,temp;
            int r;
            Console.WriteLine("enter  n number");
            n=Convert.ToInt32(Console.ReadLine());    //assume n=121
            temp = n;
             while(n>0)  // if condition is ture enter to loop

            {
                r = n % 10;                               // loop1:r=1          // loop2 r=2          loop=3=r=1
                sum = (sum * 10) + r;                      // loop1 :sum=1       //loop2   sum=12*    loop3 sum=
                n = n / 10;                                 // loop1 n=12        //loop2   n= 1         loop3  n=

            }
            if(sum==temp)
            {  
                Console.WriteLine("it is a palendrome");
            }
            else
            {
                Console.WriteLine(" it is not a palendrome");
            }


        }
    }
    internal class Palendrome
    {
    }
}
