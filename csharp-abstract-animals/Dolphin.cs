using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{
    internal class Dolphin : Animal, ISwimmer
    {
        public override void AnimalCall()
        {
            Console.WriteLine("Sciao Belo!");
        }

        public override void Eat()
        {
            Console.WriteLine("Fish");
        }

        public void Swim()
        {
            Console.WriteLine("Sto nuotando");
        }
    }
}
