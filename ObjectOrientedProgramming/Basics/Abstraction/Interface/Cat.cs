using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgramming.Basics.Abstraction.Interface
{
    class Cat : IAnimal
    {
        public string GetSound()
        {
            return "Meow meow";
        }
    }
}
