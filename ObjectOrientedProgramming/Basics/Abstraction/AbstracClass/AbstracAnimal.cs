using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgramming.Basics.Abstraction
{
    abstract class AbstracAnimal
    {
        public string AnimalSound { internal get; set; }

        public abstract string GetSound();
    }
}
