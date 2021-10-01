namespace NurseryRhymePolymorphism.Models
{
    public class Pig : Animal
    {
        public Pig(): base() { }

        public override void MakeSound()
        {
            this.Sound = "oink";
        }
    }
}
