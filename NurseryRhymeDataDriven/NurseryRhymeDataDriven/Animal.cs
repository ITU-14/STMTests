namespace NurseryRhymeDataDriven
{
    public class Animal
    {
        public string Name { get; set; }

        public string Sound { get; set; }

        public Animal(string name, string sound)
        {
            this.Name = name;

            this.Sound = sound;
        }
    }
}
