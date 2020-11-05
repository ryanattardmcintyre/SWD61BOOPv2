using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4_Polymorphism_Worksheet
{
    public class Dog: Animal
    {
        public override void Speak()
        {
            Console.WriteLine("Hello! I am a dog animal!!");
        }
    }
}
