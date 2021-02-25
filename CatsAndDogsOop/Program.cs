using System;

namespace CatsAndDogsOop
{
    class Program
    {
        class Pet
        {
            public string name;
            public string color;
            public int levelOfHappiness;

            public void PrintPetInfo()
            {
                Console.WriteLine($"Name:{name}");
                Console.WriteLine($"Color:{color}");
                Console.WriteLine($"Level of Happiness:{levelOfHappiness}");
            }
        }

        class Dog : Pet 
        {
            public Dog(string _name, string _color) //*konstruktor
            {
                name = _name;
                color = _color;
                levelOfHappiness = 0;
            }
            public void WaveTail()
            {
                levelOfHappiness += 1;

            }

            public bool Bark()
            {
                Console.WriteLine("Auh-Auh");
                return true;
            }
        }
        class Cat : Pet 
        {
            public Cat(string _name, string _color)
            {
                name = _name;
                color = _color;
                levelOfHappiness = 10;
            }
            public void HearTheDog()
            {
                levelOfHappiness = 0;
            }
            public void Hiss()
            {
                Console.WriteLine("Hsssss");
            }
        }
        static void Main(string[] args)
        {
            Dog Rex = new Dog("Rex", "black");
            Rex.PrintPetInfo();
            Cat Garfield = new Cat("Garfield", "ginger");
            Garfield.PrintPetInfo();

            for (int i = 0; i < 10; i++)
            {
                Rex.WaveTail();

            }
            bool dogBarked = Rex.Bark();
            if (dogBarked)
            {
                Garfield.HearTheDog();

            }
            if (Garfield.levelOfHappiness==0)
            {
                Garfield.Hiss();
            }

        }
    }
}
