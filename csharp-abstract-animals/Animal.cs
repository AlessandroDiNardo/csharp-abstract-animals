﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{
    public abstract class Animal
    {
        public void Sleep() => Console.WriteLine("Zzzz...");
        public abstract void Eat();
        public abstract void AnimalCall();
        public abstract void GetName();
    }
}
