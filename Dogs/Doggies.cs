using System;

namespace Dogs
{
    class Doggies
    {
        static void Main()
        {
            Dog frenchDog = new Dog("Pier", "French bouldog");
            Dog germanDog = new Dog("Hans", "German shepherd");
            Dog bgDog = new Dog("Pesho", "Karakachanka");
            frenchDog.Bark();
            germanDog.Bark();
            bgDog.Bark();
        }
    }

    public class Dog
    {
        public string name { get; set; }
        public string breed { get; set; }

        public Dog(string name, string breed)
        {
            this.name = name;
            this.breed = breed;
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public string Breed
        {
            get;
            set;
        }

        public void Bark()
        {
            if (this.breed.ToLower().Contains("french"))
            {
            Console.WriteLine("Ouaf");
                
            }
            else if (this.breed.ToLower().Contains("german"))
            {
                Console.WriteLine("Wuff, wuff");

            }
            else
            {
                Console.WriteLine("Djaff, djaff");
            }
        }
    }
}
