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
                Console.Write(num);
            }

            Console.WriteLine();

            numbers.Add(1);
            foreach (var num in numbers)
            {
                Console.Write(num);
            }

            Console.WriteLine();

            numbers.AddRange(new int[3] { 5, 6, 7 });

            foreach (var num in numbers)
            {
                Console.Write(num);
            }

            Console.WriteLine();

            Console.WriteLine("Index of the first 1 in list is: " + numbers.IndexOf(1)); ;
            Console.WriteLine("Index of the second 1 in the list is: " + numbers.LastIndexOf(1)); ;

            Console.WriteLine("Count here is: " + numbers.Count);

            for (var i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == 1)
                    numbers.Remove(numbers[i]);
            }

            foreach (var num in numbers)
            {
                Console.WriteLine(num);
            }

            numbers.Clear();
            Console.WriteLine("Final Count is: " + numbers.Count);



        }
    }
}
