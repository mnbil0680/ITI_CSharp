using D4_T1_OOP.Menu1;
using D4_T1_OOP.Employee1;
using D4_T1_OOP.Department1;
using D4_T1_OOP.Project1;

namespace D4_T1_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // create list and add 5 Employees to it
            
            //add 10

    
            Employee[] elist = new Employee[50];
            elist[0] = new Employee(1, "John", "Doe", new DateTime(1990, 1, 1), "Software Engineer", 60000, "IT", "Project A");
            elist[1] = new Employee(2, "Jane", "Smith", new DateTime(1992, 2, 2), "Data Analyst", 55000, "IT", "Project B");
            elist[2] = new Employee(3, "Alice", "Johnson", new DateTime(1988, 3, 3), "Project Manager", 70000, "Management", "Project C");
            elist[3] = new Employee(4, "Bob", "Brown", new DateTime(1995, 4, 4), "HR Manger", 50000, "HR", "Project D");
            elist[4] = new Employee(5, "Charlie", "Davis", new DateTime(1993, 5, 5), "DevOps Engineer", 65000, "IT", "Project E");


            Department[] dList = new Department[50];
            dList[0] = new Department(1, "IT", "Information Technology Department");
            dList[1] = new Department(2, "HR", "Human Resources Department");
            dList[2] = new Department(3, "Finance", "Finance Department");

            Project[] pList = new Project[50];
            pList[0] = new Project(1, "Project A", "Description of Project A", new DateTime(2020, 1, 1), new DateTime(2023, 12, 31));
            pList[1] = new Project(2, "Project B", "Description of Project B", new DateTime(2020, 2, 1), new DateTime(2023, 11, 30));
            pList[2] = new Project(3, "Project C", "Description of Project C", new DateTime(2020, 3, 1), new DateTime(2023, 10, 31));

            // Ensure MainMenu is properly referenced and exists in the Menu namespace
            Menu menu = new Menu();
            menu.LoginMenu(elist,dList,pList);
        }
    }
}
