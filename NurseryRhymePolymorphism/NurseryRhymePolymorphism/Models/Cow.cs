namespace NurseryRhymePolymorphism.Models
{
    public class Cow : Animal
    {
        public Cow(): base() { }

        public override void MakeSound()
        {
            this.Sound = "moo";
        }
    }
}
