namespace Class02.Models
{
    public class Module
    {
        public Module()
        {
            
        }

        public Module(string name, int numberOfClass)
        {
            Name = name;
            NumberOfClass = numberOfClass;
        }

        public string Name { get; set; }
        public int NumberOfClass { get; set; }
    }
}
