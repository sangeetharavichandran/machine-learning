using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Welcome");
            List<int> list = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                list.Add(i + 1);
            }
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }

    }
}
