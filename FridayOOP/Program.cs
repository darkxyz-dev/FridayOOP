using System;

namespace FridayOOP
{
    class Program
    {
        class Cat
        {
            string name;
            string color;
            double hunger;  

            public Cat(string _name, string _color)
            {
                name = _name;
                color = _color;
                hunger = 0;

            }
             public string Name
             {
                get { return name; }

             }
            public string Color
            {
                get { return color; }
            }

            public double Hunger
            {
                get { return hunger; }
            }

            public void Sleep()
            {
                hunger += 0.2;
            }
            public void Meow()
            {
                Console.WriteLine("Meow");
            }

            public void ShowCatDetails()
            {
                Console.WriteLine($"Cat name: {name}; Cat color: {color}; Cat hunger: {hunger}; ");
            }



        }
        static void Main(string[] args)
        {
            Cat newCat = new Cat("Donk", "White");
            while (newCat.Hunger != 1)
            {
                newCat.Sleep();
                newCat.Meow();
                
            }
            newCat.ShowCatDetails();
        }
    }
}
