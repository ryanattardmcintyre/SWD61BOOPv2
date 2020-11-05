using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4_Polymorphism_Worksheet
{
    class Cat: Animal
    {
        public override void Speak()
        {
            Console.WriteLine("Hello! I am a cat animal!!");
        }
    }
}
