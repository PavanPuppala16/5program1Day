using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5program1Day
{
    public class swaping {
        public void Swap()
        {
            int a, b;

            Console.WriteLine("enter a number");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter b number");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("----before swaping----");
            Console.WriteLine(a);
            Console.WriteLine(b);

            a = a + b;//  assume a=10  b=12     a=22
            b = a - b;//b=22-12 =10
            a = a - b;// a=22-10 =12
            Console.WriteLine("----after swaping----");
            Console.WriteLine("a="+a);
            Console.WriteLine("b="+b);   
           
           


        }
    }


  public class Fabonaoic
    {
        public void fabonoic()
        {
            int n1 = 0, n2 = 1, n3;
            int n;
            Console.WriteLine("Enter n value");
            n=Convert.ToInt32(Console.ReadLine());  
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            for(int i=1;i<n;i++)
            {
                n3 = n1 + n2;
                Console.WriteLine(n3);
                n1 = n2;
               
                n2 = n3;
            }
        }
    }

    public class palendrome
    {
        public void PalendromeNo()
        {
            int n, sum = 0, i, temp,r;
            Console.WriteLine("Enter n value");
            n = Convert.ToInt32(Console.ReadLine());
            temp = n;
            while(n>0)
            {
                r = n % 10;
                sum = (sum * 10) + r;
                n = n / 10;
            }
            if(temp==sum)
            {
                Console.WriteLine("it is palendrome");

            }
            else
            {
                Console.WriteLine("it is  not palendrome");

            }

        }
    }
    public class palendrome1
    {
        public void PalendromeNo1()
        {
            int n, sum = 0, i, temp, r;
            Console.WriteLine("Enter n value");
            n = Convert.ToInt32(Console.ReadLine());
            temp = n;
            while (n > 0)
            {
                r = n % 10;
                sum = sum  + r*r*r;
                n = n / 10;
            }
            if (temp == sum)
            {
                Console.WriteLine("it is amstrong");

            }
            else
            {
                Console.WriteLine("it is  not amstrong");

            }

        }
    }

    public class factorial
    {
        public void fact()
        {
            int i;
            long n,fact=1;
           
            Console.WriteLine("Enter n value");
            n = Convert.ToInt64(Console.ReadLine());
            for(i=1;i<=n; i++)
            {
                fact = fact * i;
            }
            Console.WriteLine(fact);

        }
    }
    public class prime
    {
        public void PrimeNo()
        {
            int n, a, i;
;
            Console.WriteLine("Enter n value");
            n = Convert.ToInt32(Console.ReadLine());

            a = 0;
            for(i=1;i<=n;i++)
            {
                if(n%i==0)
                    {
                    a++;

                }
               
            }
            if (a == 2)
            {
                Console.WriteLine("it is prime");
            }
            else
            {
                Console.WriteLine("it is not prime");
            }
        }
    }



















    internal class P1Swap
    {
    }
}
