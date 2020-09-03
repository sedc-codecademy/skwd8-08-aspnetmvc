using System;
using System.Collections.Generic;

namespace Class04.Models
{
    public static class DataHelper
    {
        public static List<Person> People = new List<Person>()
        {
            new Person("Risto", "Panchevki", "Macedonian", "Software Developer", new List<WorkingHour>()
            {
                new WorkingHour(new DateTime(2020, 9, 2, 7, 25, 0), new DateTime(2020, 9, 2, 16, 00, 0)),

                new WorkingHour(new DateTime(2020, 9, 3, 8, 00, 0), new DateTime(2020, 9, 3, 16, 30, 0))
            }, "Good Developer"),
            new Person("Petko", "Petkovski", "Macedonian", "Software Developer", new List<WorkingHour>{
                new WorkingHour(new DateTime(2020, 9, 2, 9, 00, 0), new DateTime(2020, 9, 2, 19, 00, 0)),

                new WorkingHour(new DateTime(2020, 9, 3, 10, 00, 0), new DateTime(2020, 9, 3, 16, 00, 0))
            }, "Excellent Developer")
        };

    }
}
