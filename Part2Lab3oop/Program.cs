namespace Part2Lab3oop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the dog's name:");
            string dogName = Console.ReadLine();
            Dog dog = new Dog();
            dog.Name = dogName;
            dog.Colour = "Brown"; 
            dog.Height = 18; 
            dog.Age = 2; 

            Console.WriteLine($"Dog's Name: {dog.Name}");
            Console.WriteLine($"Dog's Colour: {dog.Colour}");
            Console.WriteLine($"Dog's Height: {dog.Height} cm");
            Console.WriteLine($"Dog's Age: {dog.Age}");
            dog.Eat();
            Console.WriteLine($"Dog says: {dog.Cry()}");

            Console.WriteLine("\nEnter the cat's name:");
            string catName = Console.ReadLine();
            Cat cat = new Cat();
            cat.Name = catName;
            cat.Colour = "White"; 
            cat.Height = 20;
            cat.Age = 9;

            Console.WriteLine($"Cat's Name: {cat.Name}");
            Console.WriteLine($"Cat's Colour: {cat.Colour}");
            Console.WriteLine($"Cat's Height: {cat.Height} cm");
            Console.WriteLine($"Cat's Age: {cat.Age}");
            cat.Eat();
            Console.WriteLine($"Cat says: {cat.Cry()}");

            List<IAnimal> animals = new List<IAnimal>();
            animals.Add(dog);
            animals.Add(cat);

            Console.WriteLine("\nNames of all the animals:");
            foreach (var animal in animals)
            {
                Console.WriteLine(animal.Name);
            }
        }
    }
}
