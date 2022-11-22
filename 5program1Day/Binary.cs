using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _5program1Day
{

    internal class Binary
    {


        public void converting()
        {
            int i, n;
            int[] a =new int[10];
            Console.WriteLine("enter your number");
            n=Convert.ToInt32(Console.ReadLine());  
            for(i=0;n>0;i++)
            {
                a[i] = n % 2;
                n = n / 2;
            }
            Console.WriteLine("decimal to binary");
            for(i=i-1;i>=0;i--)
            {
                Console.Write(a[i]);
            }

        }
        public void Sum()
        {
            Console.Write("Enter a number :");
            int n = int.Parse(Console.ReadLine());
            int rem, sum = 0;
            while(n>0)
            {
                rem = n % 10;
                sum = sum + rem;
                n = n / 10;
            }
            Console.WriteLine($"The value is :{sum}");
        }

        public void stringRevrse()
        {
            string name, rev;
            Console.WriteLine("enter your string:");
            name = Console.ReadLine();
            rev = "";
            int len;
            len = name.Length - 1;
            while(len>=0)
            {
                rev = rev + name[len];
                len--;
            }
            Console.WriteLine($"string reverse :{ rev}");
            Console.ReadLine();

            
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
            Console.Write("Decimal: "+decVal);
   
            Console.ReadLine();
        }

        public void CharecterOccurence()
        {
            string name;
            Console.WriteLine("enter your Value:");
            name = Console.ReadLine();
            
            while(name.Length > 0)
            {
                int cal = 0;
                Console.WriteLine(name[0] + "=");
                for(int j=0;j<name.Length;j++)
                {
                    if (name[0] == name[j])
                    {
                        cal++;
                    }
                }

                Console.WriteLine(cal);
                name = name.Replace(name[0].ToString(), string.Empty);

            }

        }

    }
}
