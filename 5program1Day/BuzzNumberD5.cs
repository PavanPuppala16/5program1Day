using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5program1Day
{
    internal class BuzzNumberD5
    {





        public static void DN1()
        {
            Console.Write("Enter a number : ");
            int n = int.Parse(Console.ReadLine());
            int sum = 0, rem = 0, t = n;
            string c = n.ToString();
            int l = c.Length;



            while (t > 0)
            {
                rem = t % 10;
                sum = sum + (int)Math.Pow(rem, l);
                l--;
                t /= 10;
            }
            if (sum == n)
            {
                Console.WriteLine(" Derselium Number ");
            }
            else
            {
                Console.WriteLine(" not Derselium Number ");
            }
        }

        public static void StrongNumber()
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0, rem, f, temp;
            temp = n;
            while (n > 0)
            {
                rem = n % 10;
                f = 1;
                for (int i = 1; i <= rem; i++)
                {
                    f *= i;
                }
                sum += f;
                n /= 10;
            }
            if (temp == sum)
            {
                Console.WriteLine("Strong number");
            }
            else
            {
                Console.WriteLine("Not Strong number");
            }
        }
        public static void TwistedPrime()
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0, rem, a;
            while (n > 0)
            {
                rem = n % 10;
                sum = sum * 10 + rem;
                n /= 10;
            }
            a = 0;
            for (int i = 2; i <= sum / 2; i++)
            {
                if (sum % i == 0)
                {
                    a = 1;
                    break;
                }
            }
            if (a == 0)
            {
                Console.WriteLine("Twisted Prime Number");
            }
            else
            {
                Console.WriteLine("Not Twisted Prime Number");
            }
        }
        public static void BuzzNumber()
        {
            int n = int.Parse(Console.ReadLine());
            if (n % 10 == 7 || n % 7 == 0)
            {
                Console.WriteLine("Buzz Number");
            }
            else
            {
                Console.WriteLine("Not Buzz Number");
            }
        }
        public static void Kaprekar()
        {
            int n = int.Parse(Console.ReadLine());
            int temp, sum = 0, sq;
            sq = n * n;
            temp = sq;
            string s = sq.ToString();
            int d = s.Length;
            int k = (int)Math.Pow(10, (d / 2));
            while (temp > 0)
            {
                sum = sum + (temp % k);
                temp = temp / k;
            }
            if (sum == n)
                Console.WriteLine(" Kaprekar Number");
            else
                Console.WriteLine("Not Kaprekar Number");
        }

    }
}
