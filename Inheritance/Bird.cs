using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Bird : Animal
    {
        public string featherColor { get; set; }
        public bool canFly { get; set; }
        public int wingSpan { get; set; }
        public string beakType { get; set; }
    }
}
