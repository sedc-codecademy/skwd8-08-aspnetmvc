using System.Collections.Generic;

namespace Class02.Models
{
    public static class DataHelper
    {
        public static List<Student> Students = new List<Student>()
        {
            new Student(1, "Risto", "Panchevski", 31),
            new Student(2, "Martin", "Andreev", 29),
            new Student(3, "Test", "Test", 21),
            new Student(4, "Test 1", "Test 1", 25)
        };
    }
}
