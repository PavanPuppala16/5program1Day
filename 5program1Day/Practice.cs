using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _5program1Day
{
    internal class Practice
    {
        //21-11-2022
        public static void buzz()
        {
           
            for(int i=1;i<=100;i++)
            {
                if(i%7==0 || i%10==7)
                {
                    Console.WriteLine(i);
                }
            }
        }
        public static void absolute()
        {
            Console.WriteLine("enter your number:");
            int n = Convert.ToInt32(Console.ReadLine());
            if(n<0)
            {
                n = (-1) * n;
            }
            Console.WriteLine(n);
        }

        public static void onetotwo()
        {
            Console.WriteLine("enter cube side:");
            int row = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter cube side:");
            int col = Convert.ToInt32(Console.ReadLine());
            int[,] a=new int[row,col];
            Console.WriteLine("enter element");
            for (int c = 0; c < row; c++)
            {
                for (int d = 0; d < col; d++)
                {
                    a[c, d] = Convert.ToInt32(Console.ReadLine());
                }
            }
                for (int c = 0; c < row; c++)
                {
                    for (int d = 0; d < col; d++)
                    {
                    Console.WriteLine(a[c,d] +"");
                }
                }
            int[] one = new int[row*col];
            int e, f, g = 0;
            for( e=0;e<row;e++)
            {
                for(f=0; f<col; f++)
                {
                    g = e * col + f;
                    a[e, f] = one[g];
                }
            }
            }

        public static void kaprkar()
        {
            Console.WriteLine("enter cube side:");
            int n = Convert.ToInt32(Console.ReadLine());
            int temp, sq,sum=0;
            sq = n * n;
            temp = sq;
            string s = n.ToString();
            int m = s.Length;
            int k = (int)Math.Pow(10, (m / 2));
            while(n>0)
            {
                sum = sum + (temp % k);
                temp = temp / k;
            }
            if (sum == n) 
            {
                Console.WriteLine("it is kaaprikar:");
            }
            else
            {
                Console.WriteLine("it is not kaaprikar:");
            }
        }
        public static void buss()
        {
            Console.WriteLine("enter cube side:");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n % 10 == 7 || n % 7 == 0)
            {
                Console.WriteLine(" it is a buzz :");
            }
        }












            //20-11-2022



            public static void kaprikar()
        {
            Console.WriteLine("enter cube side:");
            int n = Convert.ToInt32(Console.ReadLine());
            int temp, sum = 0, sq;
            sq = n * n;
            temp = sq;
            string s=n.ToString();
            int d = s.Length;
            int k=(int)Math.Pow(10,(d/2));
            while(k>0)
            {
                sum = sum + (temp % k);
                temp = temp /k;


            }

        }
            
       public static void surfaceareaofcube()
        {
            Console.WriteLine("enter cube side:");
            int a = Convert.ToInt32(Console.ReadLine());
            double area = 6 * a * a;
            Console.WriteLine("area:"+area);
        }


        public static void angel()
        {
            Console.WriteLine("enter your number:");
            int h = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter your number:");
            int m = Convert.ToInt32(Console.ReadLine());
            double hd = (h * 30) + (m * 30 / 60);
            double md = m * 6;
            double diff = Math.Abs(hd - md);

            if(diff>180)
            {
                diff = 360 - diff;
            }
            Console.WriteLine(diff);
        }
        public static void Duck()
        {
            Console.WriteLine("enter your number:");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];

        }









            public static void SumofDigit()
        {
            Console.WriteLine("enter your number:");
            int n = Convert.ToInt32(Console.ReadLine());
            int rem,sum=0;
            while(n>0)
            {
                rem = n % 10;
                sum = sum + rem;
                n = n / 10;
               // n++;
            
            }
            Console.WriteLine(sum);

        }
        public static void dtob()
        {
            Console.WriteLine("enter your number:");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[100];
            int i;
            for(i=0;n>0;i++)  
            {
                a[i] = n % 2;
                n= n / 2;
            }
            for(i=i-1;i>=0;i--)
            {
                Console.Write(a[i]);
            }
        }





































        // 18-11-2022

        public static void BuzzNumber()
        {
            Console.WriteLine("enter your number:");
            int n=Convert.ToInt32(Console.ReadLine());
            if(n%10==7 || n%7==0)
            {
                Console.WriteLine("it is buzz:");
            }
            else
            {
                Console.WriteLine("it is not buzz:");
            }
        }
        public static void TwistedPrimeNo()
        {
            Console.WriteLine("enter your number:");
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = 0, rem;
            while(n>0)
            {
                rem = n % 10;
                sum = sum * 10 + rem;
                n = n / 10;
            }
            int a = 0;
            for(int i=2;i<=sum/2;i++)
            {
                if(sum/i==0)
                {
                    a = 1;

                }
            }
            if(a==1)
            {
                Console.WriteLine("number is twisted Prime");
            }
            else
            {
                Console.WriteLine("number is not twisted Prime");
            }

        }


        public static void stronngNo()
        {
            Console.WriteLine("enter your number:");
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = 0, rem,f;
            int temp = n;
            while(n>0)
            {
                rem = n % 10;
                f = 1;
                for(int i=0;i<=rem;i++)
                {
                    f = f * i;
                }
                sum = sum + f;
                n = n / 10;
            }

            if (temp==sum)
            {
                Console.WriteLine("number is twisted Prime");
            }
            else
            {
                Console.WriteLine("number is not twisted Prime");
            }
        }

      public static void karper()
        {
            Console.WriteLine("enter your number:");
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = 0, temp, sq;
            sq = n * n;
            temp = sq;
            string s = sq.ToString();
            int d = s.Length;
            int k = (int)Math.Pow(10, (d / 2));
            while(temp>0)
            {
                sum = sum + (temp % k);
                temp = temp + k;
            }
            if(sum==n)
            {
                Console.WriteLine(" is kaprikar");
            }
            else
            {
                Console.WriteLine("is not kaprikar");
            }
        }

























        //
        //17-11-2022
       public static void DuckNumber()
        {
            Console.WriteLine("enter your number:");
            int n=Convert.ToInt32(Console.ReadLine());
            int temp, a = 0;
            temp = n;
            while(n>0)
            {
                if(n%10==0)
                {
                    a = 1;
                    break;
                }
                n = n / 10;
            }
            if(temp>0&&a==1)
            {
                Console.WriteLine("it is a duck number:");

            }
            else
            {
                Console.WriteLine("it is not a duck:");
            }
        }


        public static void Angel()
        {
            Console.WriteLine("enterr hours:");
            int h = int.Parse(Console.ReadLine());
            Console.WriteLine("enterr min:");
            int m = int.Parse(Console.ReadLine());
            double hd = (h * 30) + (m * 30.0 / 60);
            double md =m* 60;
            double diff = Math.Abs(hd - md);
            if(diff>180)
            {
                diff = 360 - diff;
            }
            Console.WriteLine($"diffrence beetween{h} and {m} is differnec{diff} ");


        }






















































        //15-11-2022
        public static void Substring()
        {
            Console.WriteLine("enter your string");
            string name=Console.ReadLine();
            for(int i=1;i<=name.Length;i++)
            {
                for(int j=0;j<=name.Length-i;j++)
                {
                    Console.WriteLine(name.Substring(j, i));
                }
            }
        }

      public static  void reverseLine()
        {
            Console.WriteLine("enter your string :");
            string name = Console.ReadLine();
            string rev = string.Join("", name
                .Split(' ')
                .Select(x => new String(x.Reverse().ToArray())));

        }

        public static void Duplikate()
        {

            Console.WriteLine("enter your string :");
            string name = Console.ReadLine();
            string duplicatee =string.Empty;
            for(int i=0;i<name.Length;i++)
            {
                if (!duplicatee.Contains(name[i]))
                {
                    duplicatee = duplicatee + name[i];

                }
            }

        }

        public static void Array()
        {
            int[,] a = new int[2, 2] { { 1, 2 }, { 2, 3 } };
            int[] b = new int[4];
            int i, j, k = 0;

            for(i=0;i<a.Length;i++)
            {
                for (j = 0; j < a.Length; j++)
                {
                    Console.WriteLine("{0},{1}=a[{2}]", i, j, a[i, j]);
                }
            }

        }
































































        //14-11-2022
        public void Digit()
        {
            int sum = 0, rem;
            Console.WriteLine("enter your number");
            int n = Convert.ToInt32(Console.ReadLine());
            for(int i=0; i<n; i++)
            {
                rem = n % 10;
                sum = sum + rem;
                n = n / 10;
            }
            Console.WriteLine(sum);
        }
        public void DtoB()
        {
            Console.WriteLine("enter your number");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[10];
            int  i;
            for(i=0; n>0; i++)
            {
                a[i] = n % 2;
                n = n / 2;

            }
            for(i=i-1;i>=n;i--)
            {
                Console.Write(a[i]);
            }



        }
        public void CountStr()
        {
            Console.WriteLine("enter string:");
            string name=Console.ReadLine(); 
            while(name.Length>0)
            {
                int cal = 0;
                Console.Write(name[0] + "=");
                for(int i=0;i<name.Length;i++)
                {
                    if (name[0] == name[i])
                    {
                        cal++;
                    }
                }
                Console.WriteLine(cal);
                name = name.Replace(name[0].ToString(),String.Empty);
            }
        }



        public void CharacterCount()
        {
            Console.WriteLine("entry your string");
            string name = Console.ReadLine();
            while(name.Length>0)
            {
                Console.Write(name[0] + "=");
                int cal = 0;
                for(int j=0;j<name.Length;j++)
                {
                    if (name[0] == name[j])
                    {
                        cal++;
                    }
                }
                Console.WriteLine(cal);
                name=name.Replace(name[0].ToString(),String.Empty);     
            }

        }
        public void DecimalToBimary()
        {
            Console.WriteLine("enter your number:");
            int n=Convert.ToInt32(Console.ReadLine());
            int[] a= new int[10];
            int i;
          
            for( i=0;n>0;i++)
            {
                a[i] = n % 2;
                n = n / 2;
            }
            Console.WriteLine("converting to binary");
           for(i=i-1;i>=0;i--)
            {
                Console.Write(a[i]);    
            }
        }


        public void Revrsestring()
        {

            int n;
            string rev = "";
            Console.WriteLine("entry your string");
            string name = Console.ReadLine();
            int len=name.Length-1;
            while (len >= 0) { 
                rev = rev + name[len];
                len--;
                
            }
            Console.WriteLine(rev);

        }



        public void SUm()
        {
            int sum = 0;
            Console.WriteLine("enter you no");
            int n = Convert.ToInt32(Console.ReadLine());
            for(int i=0;i<n;i++)
            {
                int r = n % 10;
                 sum = sum + r;
                n = n / 10;
            }
            Console.WriteLine(sum);
        }
        public void BinaryTodecimal()
        {
            Console.WriteLine("enter your binary ");
            int n = int.Parse(Console.ReadLine());
            int a = 1, rem, sum = 0;
            while (n > 0)
            {
                rem= n % 10;
                sum = sum + rem * a;
                n = n / 10;
                a = a * 2;
            }
            Console.WriteLine(sum);
        }

        public void prime()
        {
            int i;
            Console.WriteLine("enter your no");
            int n = Convert.ToInt32(Console.ReadLine());
            int a = 0;
          for(i=1;i<n;i++)  
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
                Console.WriteLine("it is  not prime");
            }
        }
      

        public static void REVLine()
        {
            Console.WriteLine("enter your line");
            string name = Console.ReadLine();
            string rev ;
            rev = string.Join(" ", name
                .Split(' ')
                .Select(x => new string(x.Reverse().ToArray())));

            Console.Write(rev);
         }

        public static void duplicate()
        {
            Console.WriteLine("enter your line");
            string name = Console.ReadLine();
            string duplicate = "";
            for(int i=0;i<name.Length;i++)
            {
                if (!duplicate.Contains(name[i]))
                {
                    duplicate+=name[i];
                }
            }
            Console.WriteLine(duplicate);
        }

        public static void Submodustring()
        {
            Console.WriteLine("enter your line");
            string name = Console.ReadLine();
            for(int i=1;i<=name.Length;i++)
            {
                for(int j=0;j<=name.Length-i;j++)
                {
                    Console.WriteLine(name.Substring(j, i));
                }
            }

        }

        public static void ArrayConverter()
        {
            Console.WriteLine("enter your row");
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine("enter your row");
            int n = int.Parse(Console.ReadLine());
            int x = m * n;
            int[] b=new int[x];
            int[,] a = new int[m, n];
            int i, j, k = 0;
            for(i=0;i<m;i++)
            {
                for(j=0;j<n;j++)
                {
                    k = i * m + j;
                    b[k] = a[i, j];
                    k++;
                }
            }
            Console.WriteLine("one dimention");
            for(i=0;i<x;i++)
            {
                b[i] = Console.Read();
            }
            for (i = 0; i < x; i++)
            {
                Console.WriteLine(b[i] + "");
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
            for (int g = 0; g < n; g++)
            {
                for (int h = 0; h < m; h++)
                {
                    Console.Write("Enter values [{0}][{1}]", g, h);
                    b[g, h] = int.Parse(Console.ReadLine());
                }
            }
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
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < m; j++)
                    Console.Write((a[i * m + j]) + "");
            }
        }

    }
}
