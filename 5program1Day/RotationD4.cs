using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5program1Day
{
    internal class RotationD4
    {
        //17-11-2022

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
                        continue;
                    if (a[j] == a[i])
                        break;
                }
                if (n == j)
                {
                    Console.Write(a[i] + " ");
                }
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
                n= n/10;
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


























































            //Rotation of an array
            public static void LeftNotation()
        {
            int[] nums = { 1, 2, 8, 4, 5 };
            Console.WriteLine("Array1: [{0}]", string.Join(", ", nums));
            var temp = nums[0];
            for (var i = 0; i < nums.Length - 1; i++)
            {
                nums[i] = nums[i + 1];
            }
            nums[nums.Length - 1] = temp;
            Console.WriteLine("After rotating array becomes: [{0}]", string.Join(", ", nums));
        }
        public static void RightNotation()
        {
            int[] oneDimensionalArray = new int[6];
            Console.WriteLine("Enter the 1D Array Elements : ");
            for (int i = 0; i < oneDimensionalArray.Length; i++)
            {
                oneDimensionalArray[i] = int.Parse(Console.ReadLine());
            }

            int temp;
            for (int j = 0; j < oneDimensionalArray.Length - 1; j++)
            {
                temp = oneDimensionalArray[0];
                oneDimensionalArray[0] = oneDimensionalArray[j + 1];
                oneDimensionalArray[j + 1] = temp;
            }
            Console.WriteLine("Array Elements After Right Circular Rotation: ");
            foreach (int num in oneDimensionalArray)
            {
                Console.Write(num + " ");
            }
            Console.ReadKey();
        }
        //Clock Angle
        public static void ClockAngle()
        {
            Console.Write("Enter the hours : ");
            int hours = int.Parse(Console.ReadLine());
            Console.Write("Enter the Minutes : ");
            int minutes = int.Parse(Console.ReadLine());

            double hourInDegrees = (hours * 30) + (minutes * 30.0 / 60);
            double minuteInDegrees = minutes * 6;
            double diff = Math.Abs(hourInDegrees - minuteInDegrees);
            if (diff > 180)
            {
                diff = 360 - diff;
            }
            Console.WriteLine($"Angle between {hours} hour and {minutes} minute is {diff} degrees");
            Console.ReadKey();
        }
        //Duck Element of an array
        public static void DupEleArr()
        {
            int i = 0, j = 0;
            int[] arr1 = new int[] { 7, 7, 8, 8, 9, 1, 1, 4, 2, 2 };
            for (i = 0; i < arr1.Length; i++)
            {
                for (j = 0; j < arr1.Length; j++)
                {
                    if (i == j)
                        continue;
                    if (arr1[j] == arr1[i])
                        break;
                }
                if (arr1.Length == j)
                {
                    Console.Write(arr1[i] + " ");
                }
            }
        }
        //Duck Number
        public static void DuckNo()
        {
            Console.Write("Enter a Number :");
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
                n /= 10;
            }
            if (temp > 0 && a == 1)
            {
                Console.WriteLine(temp + "Given Number is a Duke Number");
            }
            else
            {
                Console.WriteLine(temp + "Given Number is not a Duke Number");
            }
        }
    }
}
