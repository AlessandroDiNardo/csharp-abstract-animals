using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{
    internal class Dog : Animal
    {
        public override void AnimalCall()
        {
            Console.WriteLine("Woof woof");
        }

        public override void Eat()
        {
            Console.WriteLine("Meat");
        }
    }
}
