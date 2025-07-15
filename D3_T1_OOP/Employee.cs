using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D3_T1_OOP
{
    class Employee
    {
        public int id;
        public string name;
        public double salary;
        public int age;
        public bool isMarried;
        public char Gender;

        public int GetId()
        {
            return id;
        }
        public void SetId(int _id)
        {
            id = _id;
        }
        public string GetName()
        {
            return name;
        }
        public void SetName(string _name)
        {
            name = _name;
        }
        public double GetSalary()
        {
            return salary;
        }
        public void SetSalary(double _salary)
        {
            salary = _salary;
        }

        public int GetAge()
        {
            return age;
        }
        public void SetAge(int _age)
        {
            age = _age;
        }
        public bool GetIsMarried()
        {
            return isMarried;
        }
        public void SetIsMarried(bool _isMarried)
        {
            isMarried = _isMarried;
        }

        public char GetGender()
        {
            return Gender;
        }

        public void SetGender(char _Gender)
        {
            Gender = _Gender;
        }
        public Employee()
        {
            id = 0;
            name = "Unknown";
            salary = 0.0;
        }

        // parameterized constructor
        //wrwith parameters
        

        public override string ToString()
        {
            return $"ID: {id}, Name: {name}, Salary: {salary}";
        }
        public Employee(int _id, string _name, double _salary, int _age, bool _isMarried, char _gender)
        {
            id = _id;
            name = _name;
            salary = _salary;
            age = _age;
            isMarried = _isMarried;
            Gender = _gender;
        }

    }
}
