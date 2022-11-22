using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _5program1Day
{
    internal class TotalPrograms
    {

        // total programs

        public static void swap()
        {
            Console.WriteLine("enter your number:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter your number:");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("before swaping :");
            Console.WriteLine("a={0}", a);
            Console.WriteLine("b={0}", b);
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine("after swaing :");
            Console.WriteLine("a={0}", a);
            Console.WriteLine("b={0}", b);


        }

        public static void sumofDigits()
        {
            Console.WriteLine("enter your number:");
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = 0, r;
            for (int i = 0; i < n; i++)
            {
                r = n % 10;
                sum = sum + r;
                n = n / 10;
            }
            Console.WriteLine("sum is:{0}", sum);
        }

        public static void decimalTobinary()
        {
            Console.WriteLine("enter your number:");
            int a = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[10];
            int i;
            for (i = 0; a > 0; i++)
            {
                arr[i] = a % 2;
                a = a / 2;
            }
            Console.WriteLine("the decimal num to binary:");
            for (i = i - 1; i >= 0; i--)
            {
                Console.WriteLine(arr[i]);
            }

        }

        public void BinaryTodecimal()
        {
            int num, binVal, decVal = 0, baseVal = 1, rem;
            // num = 101;
            Console.WriteLine("enter your Value:");
            num = Convert.ToByte(Console.ReadLine());
            binVal = num;
            while (num > 0)
            {
                rem = num % 10;
                decVal = decVal + rem * baseVal;
                num = num / 10;
                baseVal = baseVal * 2;
            }
            Console.Write("Binary Number: " + binVal);
            Console.Write("Decimal: " + decVal);

            Console.ReadLine();
        }

        public static void CharacterOccurence()
        {
            Console.WriteLine("enter your sting:");
            string name = Console.ReadLine();
            while (name.Length > 0)
            {
                int cal = 0;
                Console.WriteLine(name[0] + "  ");
                for (int i = 0; i < name.Length; i++)
                {
                    if (name[0] == name[i])
                    {
                        cal++;
                    }
                }
                Console.WriteLine(cal);
                name = name.Replace(name.ToString(), String.Empty);
            }


        }


        public static void RDEIA1()
        {
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[50];
            int i, j;
            for (i = 0; i < n; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            for (i = 0; i < n; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    if (i == j)
                        Console.Write(a[i] + " ");
                    if (a[j] == a[i])
                        break;
                }
                //if (n == j)
                //{
                //    Console.Write(a[i] + " ");
                //}
            }
            Console.WriteLine();
        }
        //Finding the angle between the hour and minute hands of a clock at any given time:
        public static void Ang()
        {
            Console.Write("Enter Hours : ");
            int h = int.Parse(Console.ReadLine());
            Console.Write("Enter Minutes : ");
            int m = int.Parse(Console.ReadLine());
            double hd = (h * 30) + (m * 30.0 / 60);
            double md = m * 6;
            double diff = Math.Abs(hd - md);
            if (diff > 180)
            {
                diff = 360 - diff;
            }
            Console.WriteLine($"Angle between {h} hour and {m} minute is {diff} degrees");
        }
        //Duck number
        public static void DN()
        {
            int n = int.Parse(Console.ReadLine());
            int temp, a = 0;
            temp = n;
            while (n > 0)
            {
                if (n % 10 == 0)
                {
                    a = 1;
                    break;
                }
                n = n / 10;
            }
            if (temp > 0 && a == 1)
            {
                Console.WriteLine("Given Number is a Duke Number");
            }
            else
            {
                Console.WriteLine("Given Number is not a Duke Number");
            }
        }
        public static void RightRotation()
        {
            Console.Write("Enter a number : ");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("   ---   Array elements   ---   ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();
            int temp;
            for (int j = 0; j < n - 1; j++)
            {
                temp = a[0];
                a[0] = a[j + 1];
                a[j + 1] = temp;
            }
            Console.WriteLine("   ---   After Right circular rotation   ---   ");
            foreach (int i in a)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }

        public void Checking()
        {
            bool isprime = true;
            Console.WriteLine("prime numbers");
            for (int i = 2; i < 100; i++)

            {
                for (int j = 2; j < 100; j++)
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
        public void PrimeNo1()
        {
            int n, i, a;
            Console.WriteLine("enter a number");
            n = Convert.ToInt32(Console.ReadLine());
            a = 0;
            for (i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    a++;
                }
            }
            if (a == 2)
            {
                Console.WriteLine("it is a prime number");
            }
            else
            {
                Console.WriteLine("it is not a prime number");
            }
        }
        public void fact()
        {
            int i;
            long n, fact = 1;

            Console.WriteLine("Enter n value");
            n = Convert.ToInt64(Console.ReadLine());
            for (i = 1; i <= n; i++)
            {
                fact = fact * i;
            }
            Console.WriteLine(fact);

        }
        public void PalendromeNo()
        {
            int n, sum = 0, i, temp, r;
            Console.WriteLine("Enter n value");
            n = Convert.ToInt32(Console.ReadLine());
            temp = n;
            while (n > 0)
            {
                r = n % 10;
                sum = (sum * 10) + r;
                n = n / 10;
            }
            if (temp == sum)
            {
                Console.WriteLine("it is palendrome");

            }
            else
            {
                Console.WriteLine("it is  not palendrome");

            }

        }
        public void fabonoic()
        {
            int n1 = 0, n2 = 1, n3;
            int n;
            Console.WriteLine("Enter n value");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            for (int i = 1; i < n; i++)
            {
                n3 = n1 + n2;
                Console.WriteLine(n3);
                n1 = n2;

                n2 = n3;
            }
        }
        public static void REV()
        {
            Console.WriteLine("enter your string :");
            string name = Console.ReadLine();
            string rev = string.Join("",
                name.Split(' ')
                .Select(x => new string(x.Reverse().ToArray())));
            Console.WriteLine(rev);

        }
        public static void substring()
        {
            string input_string;
            Console.Write("Enter String : ");

            Console.Write("\n");

            input_string = Console.ReadLine();
            int j = 0;

            int i = 0;
            for (i = 1; i <= input_string.Length; i++)

            {
                for (j = 0; j <= input_string.Length - i; j++)

                {
                    Console.WriteLine(input_string.Substring(j, i));

                }
            }
        }
        public static void Dublicate()
        {
            Console.WriteLine("Enter the string:");
            string s = Console.ReadLine();
            string r = string.Empty;
            for (int i = 0; i < s.Length; i++)
            {
                if (!r.Contains(s[i]))
                {
                    r += s[i];
                }
            }
            Console.WriteLine(r);
        }
        public static void ODTT()
        {
            Console.Write("Enter no of Rows :");
            int m = int.Parse(Console.ReadLine());
            Console.Write("Enter no of coloum :");
            int n = int.Parse(Console.ReadLine());
            int x = m * n;
            int[] a = new int[x];
            int[,] b = new int[m, n];
            int k, l, z = 0;
            for (k = 0; k < m; k++)
            {
                for (l = 0; l < n; l++)
                {
                    z = k * m + l;
                    b[k, l] = a[z];
                    z++;



                }
            }
            for (int i = 0; i < x; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("One dimensional array");
            for (int i = 0; i < x; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("two dimensional array");
            for (k = 0; k < m; k++)
            {
                for (l = 0; l < n; l++)
                {
                    Console.Write(b[k, l] + " ");
                }
                Console.WriteLine();
            }
        }
        public static void TestTTO()
        {
            Console.WriteLine("Enter no of rows :");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter no of columns :");
            int m = int.Parse(Console.ReadLine());
            int[] a = new int[100];
            int[,] b = new int[n, m];
            int i, j, k = 0;
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < m; j++)
                {
                    k = i * m + j;
                    a[k] = b[i, j];
                    k++;
                }
            }
            for (int g = 0; g < n; g++)
            {
                for (int h = 0; h < m; h++)
                {
                    Console.Write("Enter values [{0}][{1}]", g, h);
                    b[g, h] = int.Parse(Console.ReadLine());
                }
            }

            for (i = 0; i < n; i++)
            {
                for (j = 0; j < m; j++)
                    Console.Write((a[i * m + j]) + "");
            }
        }
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
        public static void AreaofRectange()
        {
            Console.Write("Enter Length : ");
            int l = int.Parse(Console.ReadLine());
            Console.Write("Enter Width : ");
            int w = int.Parse(Console.ReadLine());
            int a = l * w;
            Console.WriteLine("Area of Rectangle : " + a);
        }
        public static void AreaofSquare()
        {
            Console.Write("Enter square : ");
            int s = int.Parse(Console.ReadLine());
            int a = s * s;
            Console.WriteLine("Area of square : " + a);
        }
        public static void AreaofTriangle()
        {
            Console.Write("Enter Height: ");
            int h = int.Parse(Console.ReadLine());
            Console.Write("Enter Base : ");
            int b = int.Parse(Console.ReadLine());
            int a = (1 / 2) * b * h;
            Console.WriteLine("Area of Traingle : " + a);
        }
        public static void AreaofCircle()
        {
            Console.Write("Enter radius: ");
            int r = int.Parse(Console.ReadLine());
            double a = 3.141 * (r * r);
            Console.WriteLine("Area of Circle : " + a);
        }
        public static void SurfaceAreaofCube()
        {
            Console.Write("Enter side Length of the Cube: ");
            int a = int.Parse(Console.ReadLine());
            double area = 6 * (a * a);
            Console.WriteLine("Surface area of cube : " + area);
        }
    }
}

