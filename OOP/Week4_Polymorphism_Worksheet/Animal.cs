using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4_Polymorphism_Worksheet
{
    public class Animal
    {
        public virtual void Speak()
        {
            Console.WriteLine("Hello! I am a generic animal!!");
        }
    }
}
