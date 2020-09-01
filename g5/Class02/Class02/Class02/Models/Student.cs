using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Class02.Models
{
    public class Student
    {
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        [DisplayName("Last Name")]
        public string LastName { get; set; }
        public string FullName => $"{FirstName} {LastName}";
        [Required]
        public int Age { get; set; }
        public dynamic Other { get; set; }

        public Student()
        {
        }

        public Student(int id, string firstName, string lastName, int age)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }
    }
}
