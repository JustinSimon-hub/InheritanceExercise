using System;
using System.Collections.Generic;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes



            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class



            //     public string Name { get; set; }
            //public int Age { get; set; }
            //public string Habitat { get; set; }
            //public string Sex { get; set; }
            Bird birdie = new Bird
            {
                Name = "Parrot",
                Age = 2,
                Habitat = "Tropical forests",
                Sex = "Male", 
                featherColor = "Red and Green",
                canFly = true,
                wingSpan = 12,

            };


            Reptile reptile = new Reptile
            {
                Name = "Iguana",
                Age = 5,
                Habitat = "Amazon Rainforest",
                skinColor = "Green",
                isVenomous = false,
                seesInDark = true,
                lengthInInches = 24
            };


           List<Animal> animals = new List<Animal>();
            animals.Add(birdie);
            animals.Add(reptile);
            foreach (var animal in animals)
            {
                Console.WriteLine($"Name: {animal.Name}, Age: {animal.Age}, Habitat: {animal.Habitat}");
            }
        }
    }
}
