using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5program1Day
{


    public class Prime
    {
      public void PrimeNo1()
        {
            int n, i,a;
            Console.WriteLine("enter a number");
            n = Convert.ToInt32(Console.ReadLine());
            a = 0;
            for(i=1;i<=n; i++)
            {
                if(n%i==0)
                {
                    a++;
                }
            }
            if(a==2)
            {
                Console.WriteLine("it is a prime number");
            }
            else
            {
                Console.WriteLine("it is not a prime number");
            }
        }
    }




    public class PrinmeChecking
    {
        public void Checking()



        {



            bool isprime = true;
            Console.WriteLine("prime numbers");
            for(int i=2;i<100;i++)

            {
                for(int j=2;j<100;j++)
                {
                    if (i != j && i % j == 0)
                    {
                        isprime = false;
                        break;
                    }
                }
                if (isprime)
                {
                    Console.Write("\t" + i);
                }
                isprime = true;
            }
            Console.ReadKey();
        }
    }











            //int n, i, a,flag=1;
            //Console.WriteLine("enter a number");
            //n = Convert.ToInt32(Console.ReadLine());
           
            //for (i = 1; i <= n; i++)
            //{
            //    if (n % 2 == 0)
            //    {
            //        flag = 0;
            //    }
            //    Console.WriteLine(" prime number" + n);
     
    internal class PrimeNo
    {
    }
}
