using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.UsingLists
{
    internal class ListTester
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> {6, 7, 21 };

            Display(numbers);

            numbers.Add(2);
            numbers.Add(7);
            Display(numbers);
                        
            numbers.Insert(3, 3);
            Display(numbers);

            numbers.Remove(7);
            numbers.Add(100);
            numbers.RemoveAt(numbers.Count - 2);
            Display(numbers);

            // Search for number
            Console.Write("Enter a number to search in the list: ");
            int searchNumber;
            if (int.TryParse(Console.ReadLine(), out searchNumber))
            {
                bool found = SearchNumber(numbers, searchNumber);
                Console.WriteLine($"The number {searchNumber} is {(found ? "found" : "not found")} in the list.");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }

            CalculateEvenNums(numbers);

            CalculateAverage(numbers);

            calculateMultiples(numbers);

        }

        private static void calculateMultiples(List<int> numbers)
        {
            Console.WriteLine("Multiples of 3 and 7");
            foreach (int item in numbers)
            {
                if (item % 3 == 0 && item % 7 ==0)
                {
                    Console.WriteLine(item);
                }
            }
        }

        private static void CalculateAverage(List<int> numbers)
        {
            int sum = 0;
            int count = 0;
            int average = 0;

            foreach (int item in numbers)
            {
                if (item % 2 != 0)
                {
                    sum += item;
                    count++;
                }
            }
            average = sum / count;
            Console.WriteLine($"Average of odd numbers: {average}");
            Console.WriteLine("==========================");
        }

        private static void CalculateEvenNums(List<int> numbers)
        {
            int sum = 0;
            foreach (int item in numbers)
            {
                if (item % 2 == 0)
                {
                    sum += item;
                }
            }

            Console.WriteLine($"Sum of even numbers: {sum}");
            Console.WriteLine("==========================");
        }


        private static bool SearchNumber(List<int> numbers, int numberToSearch)
        {
            return numbers.Contains(numberToSearch);
        }

        private static void Display(List<int> numbers)
        {
            foreach(int item in numbers)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("==========================");
        }

    }
}
