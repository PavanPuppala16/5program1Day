using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _5program1Day
{
    internal class revrse
    {

        public static void REV()
        {
            Console.WriteLine("enter your string :");
            string name = Console.ReadLine();
            string rev = string.Join("",
                name.Split(' ')
                .Select(x => new string(x.Reverse().ToArray())));
            Console.WriteLine(rev);

        }
    }
}
