namespace NurseryRhymePolymorphism.Models
{
    public class Cat : Animal
    {
        public Cat():base() { }

        public override void MakeSound()
        {
            this.Sound = "miaow";
        }
    }
}
