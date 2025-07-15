using System;
using System.Collections.Generic;

namespace D4_T1_OOP.Employee1
{
    public class Employee : Person
    {

        public int ID { get; set; }
        public string Position { get; set; }
        public decimal Salary { get; set; }
        public string Department { get; set; }

        public string Project { get; set; }

        // Constructor for the Employee class  
        public Employee(int ID, string firstName, string lastName, DateTime birthDate, string position, decimal salary, string department, string project) : base(firstName, lastName, birthDate)
        {
            this.ID = ID;
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthDate;
            Position = position;
            Salary = salary;
            Department = department;
            Project = project;
        }


    }
}

