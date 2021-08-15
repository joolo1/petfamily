using System;
using System.Collections.Generic;

namespace JoppesDjurfamilj
{
    class PetOwner
    {
        private int age = 20;
        private List<Animal> animals = new List<Animal>();
        private Ball ball;

        public void ListAnimals()
        {
            Console.Clear();
            Console.WriteLine(".:-##### Joppes Djur #####-:.");

            int counter = 1;

            for (int i = 0; i < animals.Count; i++)
            {
                Console.WriteLine($"{counter}. {animals[i].Name}");
                counter++;
            }

            Console.ReadKey();
        }

        public void Play()
        {

        }

        public void Feed()
        {

        }

        public void Menu()
        {
            // Joppe has some animals already, lets add those to the list
            animals.Add(new Dog("Arro", 9));
            animals.Add(new Puppy("Arro Jr.", 23));

            do
            {
                while (!Console.KeyAvailable)
                {
                    Console.Clear();

                    Console.WriteLine("Hey Joppe! What do you want to do today?");
                    Console.WriteLine("A: List all my animals");
                    Console.WriteLine("B: Play with an animal");
                    Console.WriteLine("C: Feed one of my animals");

                    ConsoleKey key;
                    key = (ConsoleKey)Console.Read();

                    switch (key)
                    {
                        case ConsoleKey.A:
                            ListAnimals();
                            break;
                        default:
                            break;
                    }
                }
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }

        public override string ToString()
        {
            return string.Format($"{0}");
        }
    }
}
