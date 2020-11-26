using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson9_Abstraction
{
    //Both intefaces and abstract classes enforce implementation of
    //their members upon inherited classes

    //In an Interface you do not implement
    //--> you just declare methods
    //In an Abstract class you can have a mix

    //What are the differences between Interfaces and Abstract classes?
    //When to use one and not the other?

    //1. A class can inherit more than ONE Interface, but it can inherit ONLY ONE Abstract Class
    //2. An abstract class can be composed of non-implemented methods but also implemented ones


    public interface IBackup
    {
         void Backup();
    }
}
