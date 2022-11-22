using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5program1Day
{
    internal class Substring
    {

        public static void substrings()
        {
            Console.WriteLine("enter your string :");
            string name=Console.ReadLine();
            for(int i=1;i<=name.Length;i++)
            {
                for(int j=0;j<=name.Length-i;j++)
                {
                    Console.WriteLine(name.Substring(j,i));
                }
            }
        }
        public static void Tdimento1d()
        {
            int[,] a = new int[2, 2] { { 1, 2 }, { 2, 3 } };
            int i, j, k = 0;
            int[] b = new int[4];
            Console.WriteLine("two dimentional array");
            for(i=0;i<2;i++)
            {
                for(j=0;j<2;j++)
                {
                    Console.WriteLine("a[{0},{1}]=a[2]", i, j, a[i, j]);

                }
            }
            Console.WriteLine("one dimentio array");
            for (i = 0; i < 2; i++)
            {
                for (j = 0; j < 2; j++)
                {
                    b[k++] = a[i, j];
                }
                for (i = 0; i < 2 * 2; i++)
                {
                    Console.WriteLine("{0}\t", b[i]);
                }
            }
        }

        public static void Reverse()
        {
            Console.Write("Enter a String : ");
            string originalString = Console.ReadLine();



            string reverseWordString = string.Join(" ", originalString
             .Split(' ')
             .Select(x => new String(x.Reverse().ToArray())));
            Console.WriteLine($"Reverse Word String : {reverseWordString}");

        }

        public static void array12()
        {
            Console.WriteLine("enter rows");
            int n=Console.Read();
            Console.WriteLine("enter coloumns");
            int m=Console.Read();
            int x = m * n;
            int[] a=new int[x];
            for(int i=0;i<x;i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            for(int i=0;i<x;i++)
            {
                Console.WriteLine(a[i]);
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
            }
        }

      
           
    }
}
