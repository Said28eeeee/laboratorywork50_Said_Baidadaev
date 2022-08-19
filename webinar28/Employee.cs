using System;
using System.Collections.Generic;
using System.Text;

namespace webinar28
{
    internal class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public string About { get; set; }

        public Employee(int id, string name, string surname, int age, string about)
        {
            Id = id;
            Name = name;
            Surname = surname;
            Age = age;
            About = about;
        }
        public Employee()
        {

        }
    }
}
