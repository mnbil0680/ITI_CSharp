using D4_T1_OOP.Department1;
using D4_T1_OOP.Employee1;
using D4_T1_OOP.Project1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


namespace D4_T1_OOP.Menu1
{
    #region Employee
    
    #endregion
    public class MenuHandler
    {
        public void AddEmplyee(Employee[] employees)
        {
            Console.WriteLine(" Please Enter A Valid Data for New Employee");
            Console.WriteLine("===========================================");
            Console.WriteLine();
            // Get First Name
            Console.Write("Enter Employee First Name: ");
            string Fname = Console.ReadLine();
            while (Fname =="")
            {
                Console.WriteLine("Invalid Name, Please enter a valid first name");
                Console.Write("Enter Employee First Name: ");
                Fname = Console.ReadLine();
            }

            // Get Last Name
            Console.Write("Enter Employee Last Name: ");
            string Lname = Console.ReadLine();
            while (Lname == "")
            {
                Console.WriteLine("Invalid Name, Please enter a valid last name");
                Console.Write("Enter Employee Last Name: ");
                Lname = Console.ReadLine();
            }

            // Get Birth Date
            DateTime birthDate;
            Console.Write("Enter Birth Date (yyyy-MM-dd): ");
            while (!DateTime.TryParse(Console.ReadLine(), out birthDate))
            {
                Console.WriteLine("Invalid date format. Please enter a valid date (yyyy-MM-dd): ");

            }

            // Get Position
            Console.Write("Enter Position: ");
            string position = Console.ReadLine();
            while (position == "")
            {
                Console.WriteLine("Invalid Position, Please enter a valid position");
                Console.Write("Enter Position: ");
                position = Console.ReadLine();
            }

            // Get Salary
            Console.Write("Enter Salary: ");
            decimal salary = decimal.Parse(Console.ReadLine());
            while ( salary <= 0)
            {
                Console.WriteLine("Invalid salary. Please enter a valid positive number.");
                Console.Write("Enter Salary: ");
                salary = decimal.Parse(Console.ReadLine());
            }

            // Get Department
            Console.Write("Enter Department: ");
            string department = Console.ReadLine();
            while (department=="")
            {
                Console.WriteLine("Invalid Department, Please enter a valid department");
                Console.Write("Enter Department: ");
                department = Console.ReadLine();
            }

            // Get Project
            Console.Write("Enter Project: ");
            string project = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(project))
            {
                Console.WriteLine("Invalid Project, Please enter a valid project");
                Console.Write("Enter Project: ");
                project = Console.ReadLine();
            }


            int newid = 0;
            for (int i = 0; i <= employees.Length; i++)
            {
                if (employees[i] == null)
                {
                    newid = i + 1;
                    break;
                }
            }



            employees[newid - 1] = new Employee(newid, Fname, Lname, birthDate, position, salary, department, project);
            Console.WriteLine($"Employee {Fname} {Lname} added successfully with ID: {newid}");


            Console.WriteLine();
            Console.Write("Press Any key to Return to Main Menu: ");
            Console.ReadKey();
            Console.Clear();



        }

        public void UpdateEmployee(Employee[] employees)
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
                if (employees[i].ID == id)
                {
                   
                }
            }
            Console.WriteLine($"Sorry, We didn't find out the Emplyoee with id = {id}");
            Console.WriteLine("Press Any key to Return to Main Menu : ");
            Console.ReadKey();

        }









        public void HandelMainMenu(int choice, Employee[] E, Department[] D, Project[] P)
        {
            // 1) Employee
            // 2) Department
            // 3) Projects
            // 4) Exit

            switch (choice)
            {
                case 1:

                    Menu.EmployeeMenu(E, D, P);
                    break;
                case 2:
                    Menu.DepartmentMenu(E,D,P);
                    break;
                case 3:
                    Menu.ProjectMenu(E, D, P);
                    break;
                case 4:
                    Console.Clear();
                    Console.WriteLine("Exiting the application. Goodbye!");
                    Environment.Exit(0);
                    break;
                default:
                    
                    Console.WriteLine("Invalid choice, please try again.");
                    Menu m = new Menu();
                    m.MainMenu(E, D, P);
                    break;
                 
            }

        }
    

        public void HandleEmployeeMenu(int choice, Employee[] E, Department[] D, Project[] P)
        {
            // 1) Add Employee
            // 2) Get All Employees
            // 3) Update Employee
            // 4) Get Employee BY ID
            // 5) Return to Main Menu
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Adding Employee...");

                    break;
                case 2:
                    Menu mEmp = new Menu();
                    mEmp.GetAll("Emp", E, D, P);
                    break;
                case 3:
                    Console.WriteLine("Updating Employee...");
                    break;
                case 4:
                    Console.WriteLine("Getting Employee by ID...");
                    break;
                case 5:
                    Menu m = new Menu();
                    m.MainMenu(E, D, P);
                    break;
                default:
                    Console.WriteLine("Invalid choice, please try again.");
                    Menu m1 = new Menu();
                    m1.MainMenu(E, D, P);
                    break;
            }
        }

        public void HandleDepartmentMenu(int choice, Employee[] E, Department[] D, Project[] P)
        {
            // 1) Add Department
            // 2) Get All Departments
            // 3) Update Department
            // 4) Get Department BY ID
            // 5) Return to Main Menu
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Adding Department...");
                    break;
                case 2:
                    Menu mDep = new Menu();
                    mDep.GetAll("Dep",E,D,P);
                    break;
                case 3:
                    Console.WriteLine("Updating Department...");
                    break;
                case 4:
                    Console.WriteLine("Getting Department by ID...");
                    break;
                case 5:
                    Menu m = new Menu();
                    m.MainMenu(E,D,P);
                    break;
                default:
                    Console.WriteLine("Invalid choice, please try again.");
                    Menu m1 = new Menu();
                    m1.MainMenu(E, D, P);
                    break;
            }
        }

        public void HandleProjectMenu(int choice ,Employee[] E, Department[] D, Project[] P)
        {
            // 1) Add Project
            // 2) Get All Projects
            // 3) Update Project
            // 4) Get Project BY ID
            // 5) Return to Main Menu
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Adding Project...");
                    break;
                case 2:
                    Menu mProj = new Menu();
                    mProj.GetAll("Pro",E,D,P);
                    break;
                case 3:
                    Console.WriteLine("Updating Project...");
                    break;
                case 4:
                    Console.WriteLine("Getting Project by ID...");
                    break;
                case 5:
                    //Menu.MainMenu();
                    Menu m = new Menu();
                    m.MainMenu(E, D, P);
                    break;
                default:
                    Console.WriteLine("Invalid choice, please try again.");
                    Menu m1 = new Menu();
                    m1.MainMenu(E, D, P);
                    break;
            }
        }
    }
}

/*
 handelMainMenu(int choice, int permission) done


handelEmployeeMenu(int choice, int permission) done 5/5
handelDepartmentMenu(int choice, int permission) done 5/5
handelProjectMenu(int choice, int permission) done 5/5


 
 */
