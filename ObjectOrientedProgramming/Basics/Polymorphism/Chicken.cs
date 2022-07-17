using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgramming.Basics.Polymorphism
{
    class Chicken:Animal
    {
        public override string GetSound()
        {
            return "cookku";
        }
    }
}
