using System;
using LINQRefresher_v3.Enums;

namespace LINQRefresher_v3.Models
{
    public class Student : Person
    {
        public int StudentId { get; set; }
        public float GPA { get; set; }
        public ClassLevel Level { get; set; }
    }

    public class Person
    {
        //AGE - should be get only; use Birthdate to derive the value
        public int Age
        {
            get
            {
                int age = DateTime.Now.Year - Birthdate.Year;
                if (DateTime.Now.Month < Birthdate.Month ||
                    (DateTime.Now.Month == Birthdate.Month && DateTime.Now.Day < Birthdate.Day))
                {
                    age--;
                }

                return age;
            }
        }
        public string Name { get; set; }
        public Gender Sex { get; set; }
        public DateTime Birthdate { get; set; }
        public MaritalStatus Relationship { get; set; }
    }
}
