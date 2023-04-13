using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{
    internal class Eagle : Animal, IFlying
    {
        public override void AnimalCall()
        {
            Console.WriteLine("*Scream*");
        }

        public override void Eat()
        {
            Console.WriteLine("Meat");
        }

        public void Fly()
        {
            Console.WriteLine("Sto volando");
        }
    }
}
