namespace csharp_abstract_animals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            Eagle eagle = new Eagle();
            Dolphin dolphin = new Dolphin();
            Sparrow sparrow = new Sparrow();

            List<Animal> animals = new List<Animal>() { dog, eagle, dolphin, sparrow};

            foreach (Animal animal in animals)
            {
                animal.GetName();
                animal.Eat();
                animal.AnimalCall();
                animal.Sleep();

                if (animal is IFlying)
                    FaiVolare((IFlying)animal);
                else if (animal is ISwimmer)
                    FaiNuotare((ISwimmer)animal);

                Console.WriteLine();
            }
        }
        public static void FaiVolare(IFlying animale)
        {
            animale.Fly();
        }

        public static void FaiNuotare(ISwimmer animale)
        {
            animale.Swim();
        }
    }
}