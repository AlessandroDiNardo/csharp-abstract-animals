using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{
    internal class Eagle : Animal
    {
        public override void AnimalCall()
        {
            Console.WriteLine("*Scream*");
        }

        public override void Eat()
        {
            Console.WriteLine("Meat");
        }
    }
}
