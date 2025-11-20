using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Reptile : Animal 
    {
        public string skinColor { get; set; }
        public bool isVenomous { get; set; }
        public bool seesInDark  { get; set; }
        public int lengthInInches { get; set; }
        public override void MakeNoise()
        {
            Console.WriteLine("Hisss!");
        }
    }
}
