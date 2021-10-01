namespace NurseryRhymeDataDriven
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Old MacDonald Had a Farm - Data-Driven modeling implementation!");

            var verse = GetOldMacDonaldHadAFarmVerse();

            var animals = BuildAnimals();

            foreach (var animal in animals)
            {
                Console.WriteLine($"Verse for {animal.Name}:");
                Console.WriteLine(ApplyAnimalSoundToVerse(animal, verse));
                Console.WriteLine("\n");
            }

            #region Question 3: Allow user to provide their own animals and sounds through the console

            Console.WriteLine("Provide your own animal and sound:");

            do
            {
                Console.Write("\nName: ");

                var animalName = Console.ReadLine();

                Console.Write("Sound: ");

                var animalSound = Console.ReadLine();

                if (string.IsNullOrEmpty(animalName) || string.IsNullOrEmpty(animalSound))
                {
                    Console.WriteLine("Animal name or animal sound cannot be empty!");
                }
                else
                {
                    Console.WriteLine(ApplyAnimalSoundToVerse(new Animal(animalName, animalSound), verse));
                }
                #endregion

                Console.WriteLine("\nPress <Enter> to try again or any key to exit ... ");
            } while (Console.ReadKey().Key == ConsoleKey.Enter);

        }

        static IList<Animal> BuildAnimals()
        {
            var animals = new List<Animal>();

            animals.Add(new Animal("Dog", "woouu"));

            animals.Add(new Animal("Cat", "miaow"));

            animals.Add(new Animal("Cow", "moo"));

            animals.Add(new Animal("Duck", "quack"));

            animals.Add(new Animal("Pig", "oink"));

            #region Question 2: Including another 10 animals

            animals.Add(new Animal("Horse", "neigh"));

            animals.Add(new Animal("Chicken", "crow"));

            animals.Add(new Animal("Crab", "click"));

            animals.Add(new Animal("Donkey", "hee-haw"));

            animals.Add(new Animal("Bee", "buzz"));

            animals.Add(new Animal("Elephant", "trumpet"));

            animals.Add(new Animal("Giraffe", "hum"));

            animals.Add(new Animal("Hamster", "squeak"));

            animals.Add(new Animal("Hornet", "buzz"));

            animals.Add(new Animal("Hummingbird", "warble"));

            #endregion

            return animals;
        }

        static string GetOldMacDonaldHadAFarmVerse()
        {
            return "Old MacDonald had a farm, E I E I O,\n" +
            "And on his farm he had a {animal-name}, E I E I O.\n" +
            "With a {animal-sound} {animal-sound} here and a moo moo there,\n" +
            "Here a {animal-sound}, there a {animal-sound}, ev'rywhere a {animal-sound} {animal-sound}." +
            "Old MacDonald had a farm, E I E I O.";
        }

        static string ApplyAnimalSoundToVerse(Animal animal, string verse)
        {
            return verse.Replace("{animal-name}", animal.Name).Replace("{animal-sound}", animal.Sound);
        }
    }
}
