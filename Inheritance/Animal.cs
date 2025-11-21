using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Habitat { get; set; }
        public string Sex { get; set; }
        public string skinColor { get; set; }

        public virtual void  MakeNoise()
        {
            Console.WriteLine("Generic animal sound.");
        }

        public static int numberOfCars { get; set; }

    }
}
