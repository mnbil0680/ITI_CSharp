using System;
using System.Data;
using System.Reflection.Emit;

namespace D3_T1_OOP
{
    
    internal class Program
    {
        public static void UpdateEmployee(int id, Employee[] employees)
        {
            Console.Clear();
            Console.WriteLine("Choose From the Following Menu What you want to  Edit");
            Console.WriteLine("─────────────────────────────────────────────────────────");
            Console.WriteLine();
            /*
             * public string name;
        public double salary;
        public int age;
        public bool isMarried;
        public char Gender;
             */
            Console.WriteLine("┌───────────────────────────────────────────────────────┐");
            Console.WriteLine($"│ 1) Name                                               │");
            Console.WriteLine($"│ 2) Salary                                             │");
            Console.WriteLine($"│ 3) Age                                                │");
            Console.WriteLine("└───────────────────────────────────────────────────────┘");
            Console.WriteLine();

            Console.Write("Enter Your Choice : ");
            int choice = int.Parse(Console.ReadLine());
        Start:
            switch (choice)
            {


                case 1:
                    Console.Clear();
                    Console.WriteLine($"The Old Name is {employees[id-1].GetName()}");
                    Console.Write("Enter New Name : ");

                    string newName = Console.ReadLine();
                    while (newName == "")
                    {
                        Console.WriteLine("Invalid Name, Please enter a valid name");
                        Console.Write("Enter New Name : ");
                        newName = Console.ReadLine();
                    }
                    employees[id-1].SetName(newName);
                    Console.WriteLine($" Name is  updated to {employees[id-1].GetName()}");

                    Console.WriteLine("Press Any key to Return to Main Menu : ");
                    Console.ReadKey();
                    Console.Clear();
                    MainMenu(employees);


                    break;

                case 2:
                    Console.Clear();
                    Console.WriteLine($"The Old Salary is {employees[id].GetSalary()}");
                    Console.Write("Enter New Salary : ");

                    int newsal = int.Parse(Console.ReadLine());
                    while (newsal <= 0)
                    {
                        Console.WriteLine("Invalid Salary, Please enter a valid Salary");
                        Console.Write("Enter New Salary : ");
                        newsal = int.Parse(Console.ReadLine());
                    }
                    employees[id].SetSalary(newsal);
                    Console.WriteLine($" Salary is  updated to {employees[id].GetSalary()}");

                    Console.WriteLine("Press Any key to Return to Main Menu : ");
                    Console.ReadKey();
                    Console.Clear();
                    MainMenu(employees);
                    break;

                case 3:
                    Console.Clear();
                    Console.WriteLine($"The Old Age is {employees[id].GetAge()}");
                    Console.Write("Enter New Age : ");

                    int newAge = int.Parse(Console.ReadLine());
                    while (newAge <= 0)
                    {
                        Console.WriteLine("Invalid Age, Please enter a valid Age");
                        Console.Write("Enter New Age : ");
                        newAge = int.Parse(Console.ReadLine());
                    }
                    employees[id].SetAge(newAge);
                    Console.WriteLine($" Age is  updated to {employees[id].GetAge()}");

                    Console.WriteLine("Press Any key to Return to Main Menu : ");
                    Console.ReadKey();
                    Console.Clear();
                    MainMenu(employees);
                    break;

               

                default:
                    Console.WriteLine("Invalid Choice, Please Try Again.");
                    goto Start;


            }
        }
        public static void Option1(Employee[] employees)
        {
            Console.WriteLine(" Please Enter A Valid Data for New Employee");
            Console.WriteLine("===========================================");
            Console.WriteLine();

            // Get Name
            Console.Write("Enter Employee Name: ");
            string name = Console.ReadLine();
            while (name == "")
            {
                Console.WriteLine("Invalid Name, Please enter a valid name");
                Console.Write("Enter Employee Name: ");
                name = Console.ReadLine();
            }

            // Get Salary
            Console.Write("Enter Employee Salary: ");
            double salary = double.Parse(Console.ReadLine());
            while (salary <= 0)
            {
                Console.WriteLine("Invalid Salary, Please enter a valid positive number");
                Console.Write("Enter Employee Salary: ");
                salary = double.Parse(Console.ReadLine());
            }

            // Get Age
            Console.Write("Enter Employee Age: ");
            int age =int.Parse(Console.ReadLine());
            while (age <= 0 || age > 100)
            {
                Console.WriteLine("Invalid Age, Please enter a valid age (1-120)");
                Console.Write("Enter Employee Age: ");
                age = int.Parse(Console.ReadLine());
            }

            // Get Marital Status
            Console.Write("Is Employee Married? (Y/N): ");
            bool isMarried;
            string inputMarried = Console.ReadLine();
            if (inputMarried == "Y")
            {
                isMarried = true;
            }
            else
            {
                isMarried = false;

            }


            // Get Gender
            Console.Write("Enter Employee Gender (M/F): ");
            char gender;
            string inputGender = Console.ReadLine();
            if (inputMarried == "M")
            {
                gender = 'M';
            }
            else
            {
                gender = 'F';

            }

            int newid= 0;
            for (int i = 0; i<= employees.Length;i++)
            {
                if (employees[i] ==null)
                {
                    newid = i+1;
                    break;
                }

            }

            
                
            employees[newid-1] = new Employee(newid, name, salary, age, isMarried, gender);
            Console.WriteLine($"Employee {name} added successfully with ID: {newid}");
            

            Console.WriteLine();
            Console.Write("Press Any key to Return to Main Menu: ");
            Console.ReadKey();
            Console.Clear();
            MainMenu(employees);
        }
        public static void Option2(Employee[] employees)
        {
            // Get All Employees
            Console.WriteLine("──────────────────────────────────");
            Console.WriteLine("┌─────┬─────────────┬─────────┬─────┬─────────┬────────┐");
            Console.WriteLine("│ ID  │    Name     │ Salary  │ Age │ Married │ Gender │");
            Console.WriteLine("├─────┼─────────────┼─────────┼─────┼─────────┼────────┤");

            for (int i = 0; i < employees.Length; i++)
            {
                if (employees[i] == null)
                {
                    Console.WriteLine("└─────┴─────────────┴─────────┴─────┴─────────┴────────┘");
                    break;
                }
                else
                {
                    Employee emp = employees[i];
                    Console.WriteLine($"│ {emp.id,-3} │ {emp.name,-11} │ {emp.salary,-7} │ {emp.age,-3} │ {(emp.isMarried ? "Yes" : "No"),-7} │ {(emp.Gender == 'M' ? "Male":"Female"),-6} │");

                }

            }

            //Console.WriteLine("└─────┴─────────────┴─────────┴─────┴─────────┴────────┘");

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Press Any key to Return to Main Menu : ");
            Console.ReadKey();
            Console.Clear();
            MainMenu(employees);
        }
        public static void Option3(Employee[] employees)
        {
            Console.Write("Give me ID of Emplyoee to update:");
            int id = int.Parse(Console.ReadLine());
            while (id <= 0)
            {
                Console.WriteLine("Invalid Id, Please enter ID (Positive Integer)");
                Console.Write("Give me ID of Emplyoee to update: ");
                id = int.Parse(Console.ReadLine());
            }


            for (int i = 0; i < employees.Length; i++)
            {
                if (employees[i].GetId() == id)
                {
                    UpdateEmployee(id, employees);
                }
            }
            Console.WriteLine($"Sorry, We didn't find out the Emplyoee with id = {id}");
            Console.WriteLine("Press Any key to Return to Main Menu : ");
            Console.ReadKey();

            Console.Clear();
            MainMenu(employees);


        }
        public static void Option4(Employee[] employees)
        {

            // Get Employee By ID
            Console.Write("Enter ID to Search : ");
            int id = int.Parse(Console.ReadLine());
            while (id <=0)
            {
                Console.WriteLine("Invalid Id, Please enter ID (Positive Integer)");
                Console.Write("Enter ID to Search : ");
                id = int.Parse(Console.ReadLine());
            }

            for (int i=0; i<employees.Length;i++)
            {
                if (employees[i].GetId() == id)
                {
                    Employee emp = employees[i];
                    Console.WriteLine("┌─────┬─────────────┬─────────┬─────┬─────────┬────────┐");
                    Console.WriteLine("│ ID  │    Name     │ Salary  │ Age │ Married │ Gender │");
                    Console.WriteLine("├─────┼─────────────┼─────────┼─────┼─────────┼────────┤");
                        Console.WriteLine($"│ {emp.id,-3} │ {emp.name,-11} │ {emp.salary,-7} │ {emp.age,-3} │ {(emp.isMarried ? "Yes" : "No"),-7} │ {(emp.Gender == 'M' ? "Male" : "Female"),-6} │");
                    Console.WriteLine("└─────┴─────────────┴─────────┴─────┴─────────┴────────┘");

                    Console.WriteLine("Press Any key to Return to Main Menu : ");
                    Console.ReadKey();
                    Console.Clear();
                    MainMenu(employees);
                    
                }
            }
            Console.WriteLine($"Sorry, We didn't find out the Emplyoee with id = {id}");
            Console.WriteLine("Press Any key to Return to Main Menu : ");
            Console.ReadKey();
           
            Console.Clear();
            MainMenu(employees);





        }

        public static void MainMenu(Employee[] employees)
        {
            Console.Clear();
            Console.WriteLine("Choose From the Following Menu");
            Console.WriteLine("──────────────────────────────────");
            Console.WriteLine();
            Console.WriteLine("┌───────────────────────────────────────────────────────┐");
            Console.WriteLine($"│ 1) Add Employee                                       │");
            Console.WriteLine($"│ 2) Get All Employees                                  │");
            Console.WriteLine($"│ 3) Update Employee                                    │");
            Console.WriteLine($"│ 4) Get Employee BY ID                                 │");
            Console.WriteLine($"│ 5) Exit                                               │");
            Console.WriteLine("└───────────────────────────────────────────────────────┘");
            Console.WriteLine();

            Console.Write("Enter Your Choice : ");
            int choice = int.Parse(Console.ReadLine());
            Start:
            switch (choice)
            {
                case 1:
                    Console.Clear();
                    Option1(employees);
                    break;

                case 2:
                    Console.Clear();
                    Option2(employees);
                    break;

                case 3:
                    Console.Clear();
                    Option3(employees);
                    break;

                case 4:
                    Console.Clear();
                    Option4(employees);
                    break;
                case 5:
                    Console.Clear();
                    Console.WriteLine("Thank You For using Our Program");
                    break;

                default:
                    Console.WriteLine("Invalid Choice, Please Try Again.");
                    goto Start;
            }
        }
        static void Main(string[] args)
        {


            Employee[] employees = new Employee[200];
            //List<Employee> employees = new List<Employee>();
            // Adding Employees to the List
            
            employees[0] = new Employee(1, "Mohamed", 50000, 30, true, 'M');
            employees[1] = new Employee(2, "Ali", 80000, 20, false, 'M');
            

            
            MainMenu(employees);
           
        }
    }
}
