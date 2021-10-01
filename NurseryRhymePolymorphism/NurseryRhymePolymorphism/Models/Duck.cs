namespace NurseryRhymePolymorphism.Models
{
    public class Duck : Animal
    {
        public Duck(): base() { }

        public override void MakeSound()
        {
            this.Sound = "quack";
        }
    }
}
