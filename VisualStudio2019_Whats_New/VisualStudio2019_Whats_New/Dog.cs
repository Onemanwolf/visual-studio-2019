using System;
using System.Collections.Generic;
using System.Text;

namespace VisualStudio2019_Whats_New
{
    class Dog : IAnimal
    {
        public int Legs { get; set; }

        public bool Eat(IFood food, DateTime time) => true;
    }
}
