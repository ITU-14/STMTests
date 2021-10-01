using System;
using System.Collections.Generic;
using NurseryRhymePolymorphism.Models;

namespace NurseryRhymePolymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Old MacDonald Had a Farm - Polymorphism implementation!");

            var verse = GetOldMacDonaldHadAFarmVerse();

            var animals = new List<Animal>();

            animals.Add(new Dog());

            animals.Add(new Cat());

            animals.Add(new Cow());

            animals.Add(new Duck());

            animals.Add(new Pig());

            foreach(var animal in animals)
            {
                Console.WriteLine($"Verse for {animal.Name}:");
                Console.WriteLine(ApplyAnimalSoundToVerse(animal, verse));
                Console.WriteLine("\n");
            }
            Console.ReadKey();
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
