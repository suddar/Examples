using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgramming.Basics.Polymorphism
{
    abstract class Animal
    {
        public string Sound { get; set; }

        public abstract string GetSound();
    }
}
