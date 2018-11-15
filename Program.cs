using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
           // NewMethod();
            string[] arr = new string[] { "one", "two" };
            Console.WriteLine(arr.Length);
            var res = arr.Where(arr1 => arr1.StartsWith("t"));
            foreach (var item in res)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("enter email");
            var e = Console.ReadLine();
            if(e.Trim().ToLower().Equals("san@san.com"))
            { Console.WriteLine("valid"); }
            else
            { Console.WriteLine("not valid"); }
        }

        private static void NewMethod()
        {
            int i, number, fact;
            Console.WriteLine("Enter the Number");
            number = int.Parse(Console.ReadLine());
            fact = number;
            for (i = number - 1; i >= 1; i--)
            {
                fact = fact * i;
            }
            Console.WriteLine("\nFactorial of Given Number is: " + fact);
        }
    }
}
