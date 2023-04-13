namespace csharp_abstract_animals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            Console.WriteLine("Doggo");
            dog.Eat();
            dog.AnimalCall();
            dog.Sleep();

            Eagle eagle = new Eagle();
            Console.WriteLine("\nDaje Lazio");
            eagle.Eat();
            eagle.AnimalCall();
            eagle.Sleep();

            Dolphin dolphin = new Dolphin();
            Console.WriteLine("\nDelfino del siuu");
            dolphin.Eat();
            dolphin.AnimalCall();
            dolphin.Sleep();

            Sparrow sparrow = new Sparrow();
            Console.WriteLine("\nTitti");
            sparrow.Eat();
            sparrow.AnimalCall();
            sparrow.Sleep();

        }
    }
}