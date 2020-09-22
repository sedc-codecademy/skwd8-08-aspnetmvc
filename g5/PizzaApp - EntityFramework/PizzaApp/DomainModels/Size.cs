using System;

namespace DomainModels
{
    public class Size
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public Size()
        {
            var rnd = new Random();
            Id = rnd.Next(1, 1000000000);
        }

        public Size(string name, string description)
        {
            var rnd = new Random();
            Id = rnd.Next(1, 1000000000);
            Name = name;
            Description = description;
        }
    }
}
