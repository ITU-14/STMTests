using System;
namespace NurseryRhymePolymorphism.Models
{
    public abstract class Animal
    {
        public string Name { get; set; }

        public string Sound { get; protected set; }

        public Animal()
        {
            this.Name = this.GetType().Name;
            this.MakeSound();
        }

        public abstract void MakeSound();
    }
}
