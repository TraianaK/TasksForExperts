using System;
using System.Collections.Generic;
using System.Linq;

namespace HomeworkFromClasses
{
    class HomeworkFromClasses
    {
        static void Main()
        {
            //RepeatingStrings();
            //OddNumbers();
            //OtherWay();

        }

        private static void RepeatingStrings()
        {
            Console.WriteLine("Enter string : ");
            string str = Console.ReadLine();

            string result = new string(str.ToLower().Distinct().ToArray());
            Console.WriteLine(result);
            Console.ReadKey();
        }

        private static void OddNumbers()
        {
            List<int> numbers = new List<int> { 4, 2, 2, 5, 2, 3, 2, 3, 1, 5, 2, 6, 6, 6, }; // Output should be {5,3,3,5};

            Dictionary<int, int> result = new Dictionary<int, int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                Console.Write(numbers[i] + " , " + " "  );
            }

            foreach (int number in result.Keys)
            {
                if (result.ContainsKey(number))
                {
                    result[number]++;
                }
                else
                {
                    result.Add(number, 1);
                }
            }

            foreach (int number in numbers)
            {
                Console.WriteLine("Validating : " + number);
                int aux = (Convert.ToInt32(result[number]));
                if (aux % 2 == 1)
                {
                    Console.WriteLine("The number : {0} is repeated {1} time/s. ", number, aux);
                    result.Remove(number);
                }
                else
                {
                    Console.WriteLine("All good ! ");
                }
            }

            Console.WriteLine("The new result is : {} ", string.Join("," , result.ToArray()));
            Console.ReadKey();
        }

        private static void OtherWay()
        {

            List<int> numbers = new List<int> { 4, 2, 2, 5, 2, 3, 2, 3, 1, 5, 2, 6, 6, 6, }; // Output should be {5,3,3,5};
            List<int> result = new List<int> { 4, 2, 2, 5, 2, 3, 2, 3, 1, 5, 2, 6, 6, 6, };
            Dictionary<int, int> dictionary = new Dictionary<int, int>();

            foreach (int number in numbers)
            {
                if (dictionary.ContainsKey(number))
                {
                    dictionary[number]++;
                }
                else
                {
                    dictionary.Add(number, 1);
                }
            }

            foreach (int number in dictionary.Keys)
            {
                Console.WriteLine("Validating: " + number);
                int aux = (Convert.ToInt32(dictionary[number]));
                if (aux % 2 == 1)
                {
                    Console.WriteLine("The number: " + number + " is " + aux + " time(s) in the original List. So we are removing it because we hate odd stuff");
                    result.RemoveAll(item => item == number);
                }
                else
                {
                    Console.WriteLine("All good. Well done chap!");
                }
            }

            Console.WriteLine("The new result is : {0}", String.Join(",", result.ToArray()));
            Console.ReadKey();
        }
    }
}



