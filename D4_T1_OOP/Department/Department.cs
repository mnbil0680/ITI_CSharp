using D4_T1_OOP.Employee1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D4_T1_OOP.Department1
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Description { get; set; }
       // public string Number of Employees
       
        public Department(int id, string name, string description)
        {
            Id = id;
            Name = name;
            Description = description;

        }
        public override string ToString()
        {
            return $"Department ID: {Id}, Name: {Name}, Description: {Description}";
        }
    }

}
