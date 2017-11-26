using System;
using System.Collections.Generic;

namespace SecondTaskPersons
{
    class Person
    {
        static void Main()
        {
            Details pesho = new Details("Pesho", 21);
            Details kiro = new Details("Kiro", 26);
            pesho.Email();
            kiro.Email();

        }
    }

    public class Details
    {
        private string name { get; set; }
        private int age { get; set; }
        private string email { get; set; }

        public Details(string name, int age)
        {
            this.name = name;
            if (age >= 1 || age <= 100)
            {
                this.age = age;
            }
            else
            {
                throw new ArgumentException("This is not real age.");
            }


        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public int Age
        {
            get;
            set;

        }

        public void Email()
        {
            if (this.name.ToLower().Contains("pesho"))
            {
                Console.WriteLine("Your email is : pesho@gmail.com ");
            }
            else if (this.name.ToLower().Contains("kiro"))
            {
                Console.WriteLine("Your email is : kiro@gmail.com ");
            }
            else
            {
                throw new ArgumentException("Invalid arguments");
            }
        }

    }


}
