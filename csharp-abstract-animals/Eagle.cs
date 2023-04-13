using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{
    internal class Eagle : Animal, IFlying
    {
        public override void GetName()
        {
            Console.WriteLine("Acquila della Lazio");

        }
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
            Console.WriteLine("Acquila della Lazio vola");
        }
    }
}
