using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D4_T1_OOP.Employee1
{
    public class Person
    {
        
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public Person(string firstName, string lastName, DateTime birthDate)
        {
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthDate;
        }
        public override string ToString()
        {
            return $"{FirstName} {LastName}, born on {BirthDate.ToShortDateString()}";
        }
    }
}
