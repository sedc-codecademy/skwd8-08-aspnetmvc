using System.Collections.Generic;

namespace Class04.Models
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Nationality { get; set; }
        public string Profession { get; set; }
        public string EvaluationRemark { get; set; }

        public List<WorkingHour> WorkingHours { get; set; }

        public Person()
        {
        }

        public Person(string firstName, string lastName, string nationality, string profession, List<WorkingHour> workingHours, string evaluationRemark)
        {
            FirstName = firstName;
            LastName = lastName;
            Nationality = nationality;
            Profession = profession;
            WorkingHours = workingHours;
            EvaluationRemark = evaluationRemark;
        }
    }
}
