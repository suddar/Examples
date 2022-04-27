using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgramming.Basics.Abstraction.AbstracClass
{
    class Cat : AbstracAnimal
    {
        public override string GetSound()
        {
            return "meow meow";
        }
    }
}
