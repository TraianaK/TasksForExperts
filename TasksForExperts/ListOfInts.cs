using System;
using System.Collections.Generic;
using System.Linq;
using Wintellect.PowerCollections;

namespace TasksForExperts
{
    class ListOfInts
    {
        static void Main()
        {
            //FirstTask();
            //Top10s();
            //RepeatingChars();
            //FirstDictionary();
            //NaGospodinaDictionary();
            //OccurancesOfNumbers();
            //NaGospodinaOccurancesOfNumbers();
        }

        private static void FirstTask()
        {
            List<int> numbers = new List<int>();
            Random randomObject = new Random();

            for (int i = 1; i <= 1000; i++)
            {
                numbers.Add(randomObject.Next(1, 100000));
            }

            int min = 100000;
            int max = 0;
            long sum = 0;
            float avg = 0;

            foreach (int number in numbers)
            {
                if (number > max)
                {
                    max = number;
                }
                else if (number < min)
                {
                    min = number;
                }

                sum += number;
            }

            avg = sum / numbers.Count;

            Console.WriteLine("Average of the numbers is : {0} ", avg);
            Console.WriteLine("Max number is : {0}", max);
            Console.WriteLine("Min number is : {0}", min);
        }

        private static void Top10s()
        {
            List<int> numbers = new List<int>();
            Random randomObject = new Random();

            for (int i = 1; i < 1000; i++)
            {
                numbers.Add(randomObject.Next(1, 100000));
            }

            numbers.Sort();
            numbers.Reverse();

            int[] top10 = new int[10];

            for (int i = 0; i < 10; i++)
            {
                top10[i] = numbers[i];
            }

            Array.Sort(top10);

            foreach (int topNumber in top10)
            {
                Console.WriteLine(topNumber);
            }
        }

        private static void RepeatingChars()
        {
            Console.WriteLine("Enter a word : ");
            string word = Console.ReadLine();
            for (var i = 'a'; i < word.Length; i++)
            {
                Console.WriteLine(i);
            }

        }

        private static void FirstDictionary()
        {
            Dictionary<string, int> grades = new Dictionary<string, int>();

            grades.Add("Mihail", 5);
            grades.Add("Pesho", 4);
            grades.Add("Kiril", 3);
            grades.Add("Juja", 2);
            grades.Add("Milena", 6);

            Console.WriteLine("Enter a student name : ");
            string keyToSearch = Console.ReadLine();

            if (grades.ContainsKey(keyToSearch))
            {
                Console.WriteLine("The student exists and has this mark : {0} ", grades[keyToSearch]);
            }

            else
            {
                Console.WriteLine("The student : {0}  does not exist.", keyToSearch);
            }

        }

        private static void NaGospodinaDictionary()
        {
            Dictionary<string, int> grades = new Dictionary<string, int>();

            grades.Add("Student 1 ", 5);
            grades.Add("Student 2", 4);
            grades.Add("Student 3", 3);
            grades.Add("Student 4", 2);
            grades.Add("Student 5", 6);


            Console.WriteLine("Enter a student name : ");
            string keyToSearch = Console.ReadLine();

            if (grades.ContainsKey(keyToSearch))
            {
                Console.WriteLine("{0} score is {1} ", keyToSearch, grades[keyToSearch]);
            }
            else
            {
                Console.WriteLine("Student {0} does not exist.", keyToSearch);
            }

            Console.WriteLine("List of all students : ");
            foreach (KeyValuePair<string, int> grade in grades)
            {
                Console.WriteLine("{0} - {1}", grade.Key, grade.Value);
            }
        }

        private static void OccurancesOfNumbers()
        {
            Console.WriteLine("Enter a sequence of numbers : ");
            int[] sequence = new int[6];
            
            for (int i = 1; i < sequence.Length; i++)
            {
                sequence[i] = int.Parse(Console.ReadLine());
            }


            Dictionary<int, int> arrayOfElements = new Dictionary<int, int>();

            foreach (int number in sequence)
            {
                if (arrayOfElements.ContainsKey(number))
                {
                  Console.WriteLine(arrayOfElements[number]++);
                }
                else
                {
                    arrayOfElements.Add(number, 1);
                }
                Console.WriteLine("The number : {0} is implemented {1} times ." , number, arrayOfElements[number]);
            }

        }

        private static void NaGospodinaOccurancesOfNumbers()
        {
            int[] numbers = { 1, 2, 6, 5, 4, 2, 6, 3, 1, 2, };
            Console.WriteLine(numbers);
            Dictionary<int, int> result = new Dictionary<int, int>();
            foreach (int number in numbers)
            {
                if (result.ContainsKey(number))
                {
                    result[number]++;
                }
                else
                {
                   result.Add(number, 1);
                }
                
                Console.WriteLine(result);
            }

        }
    }
}
