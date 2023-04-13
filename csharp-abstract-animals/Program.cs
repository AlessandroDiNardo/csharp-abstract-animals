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
                animal.Eat();
                animal.AnimalCall();
                animal.Sleep();
                Console.WriteLine();
            }

            FaiNuotare(dolphin);
            FaiVolare(eagle);
            FaiVolare(sparrow);
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