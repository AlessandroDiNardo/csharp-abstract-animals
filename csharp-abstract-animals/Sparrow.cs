using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{
    internal class Sparrow : Animal
    {
        public override void Eat()
        {
            Console.WriteLine("Cereals or seeds");
        }

        public override void AnimalCall()
        {
            Console.WriteLine("Chip Chip");
        }
    }
}
