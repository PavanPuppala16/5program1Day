using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5program1Day
{
    internal class ArrayD3
    {
        public static void ReverseofEachWord()
        {
            string str = "I am going to reverse myself.";
            string strrev = "";



            foreach (var word in str.Split(' '))
            {
                string temp = "";
                foreach (var ch in word.ToCharArray())
                {
                    temp = ch + temp;
                }
                strrev = strrev + temp + "";
            }
            Console.WriteLine(strrev);

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

        public static void ex1()
        {
            int[,] a = new int[2, 2] {
         {
            1,
            2
         },{
            3,
            4
            }
         };

            int i, j;
            int[] b = new int[4];
            int k = 0;

            Console.WriteLine("Two-Dimensional Array...");
            for (i = 0; i < 2; i++)
            {

                for (j = 0; j < 2; j++)
                {
                    Console.WriteLine("a[{0},{1}] = {2}", i, j, a[i, j]);
                }
            }

            Console.WriteLine("One-Dimensional Array...");
            for (i = 0; i < 2; i++)
            {
                for (j = 0; j < 2; j++)
                {
                    b[k++] = a[i, j];
                }
            }

            for (i = 0; i < 2 * 2; i++)
            {
                Console.WriteLine("{0}\t", b[i]);
            }
            Console.ReadKey();
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

        public static void ArrayConvert()
        {
            int[,] a = new int[2, 2] { { 1, 2 }, { 2, 2 } };
            int[] b = new int[4];
            int i, j, k = 0;
            for (i = 0; i < 2; i++)
            {
                for (j = 0; j < 2; j++)
                {
                    Console.WriteLine("{0},{1}=a[{2}]", i, j, a[i, j]);

                }
            }
            Console.WriteLine("two dimentional array");
            for (i = 0; i < 2; i++)
            {
                for (j = 0; j < 2; j++)
                {
                    b[k++] = a[i, j];
                }
            }
            for (i = 0; i < 2 * 2; i++)
            {
                Console.WriteLine(b[i]);
            }
            Console.ReadKey();
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




            //Console.WriteLine("two dimensional array");
            //for (k = 0; k < m; k++)
            //{
            //    for (l = 0; l < n; l++)
            //    {
            //        Console.Write(b[k, l] + " ");
            //    }
            //    Console.WriteLine();
            //}
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

    }








}


