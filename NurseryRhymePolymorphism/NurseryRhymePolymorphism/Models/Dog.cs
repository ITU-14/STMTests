namespace NurseryRhymePolymorphism.Models
{
    public class Dog : Animal
    {
        public Dog():base() { }

        public override void MakeSound()
        {
            this.Sound = "wouu";
        }
    }
}
