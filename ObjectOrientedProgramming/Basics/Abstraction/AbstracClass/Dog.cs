using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgramming.Basics.Abstraction.AbstracClass
{
    class Dog : AbstracAnimal
    {
        public override string GetSound()
        {
            return "gau gau";
        }
    }
}
