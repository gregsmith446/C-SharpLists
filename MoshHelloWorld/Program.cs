using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoshHelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>() { 1, 2, 3, 4 };

            foreach (var num in numbers)
            {
                Console.WriteLine(num);
            }

            numbers.Add(1);
            foreach (var num in numbers)
            {
                Console.WriteLine(num);
            }

            numbers.AddRange(new int[3] { 5, 6, 7 });
            foreach (var num in numbers)
            {
                Console.WriteLine(num);
            }
        }
    }
}
