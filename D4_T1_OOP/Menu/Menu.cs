using D4_T1_OOP.Department1;
using D4_T1_OOP.Employee1;
using D4_T1_OOP.Project1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D4_T1_OOP.Menu1
{
    public class Menu
    {
        public Menu()
        {

        }

        
        public void LoginMenu(Employee[] E, Department[] D, Project[] P)
        {
            string UserName1 = "admin";
            string Password1 = "admin123";

            string UserName2 = "user";
            string Password2 = "user123";
            Console.Clear();

            Console.WriteLine();
            Console.WriteLine("\t\t\t\t┌───────────────────────────────────────────────────────┐");
            Console.WriteLine($"\t\t\t\t│            Welcome To Mangement Program               │");
            Console.WriteLine($"\t\t\t\t│                                                       │");
            Console.WriteLine($"\t\t\t\t│              Enter Your Credentials                   │");
            Console.WriteLine("\t\t\t\t└───────────────────────────────────────────────────────┘");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("\t\t\t\tUsername: ");
            string username = Console.ReadLine();
            Console.Write("\t\t\t\tPassword: ");
            string password = Console.ReadLine();
            Console.ResetColor();

            if ((username == UserName1 && password == Password1) || (username == UserName2 && password == Password2))
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\t\t\t\t┌───────────────────────────────────────────────────────┐");
                Console.WriteLine("\t\t\t\t│                   Login Successful!                   │");
                Console.WriteLine("\t\t\t\t│                                                       │");
                Console.WriteLine("\t\t\t\t│                 Welcome to the System!                │");
                Console.WriteLine("\t\t\t\t└───────────────────────────────────────────────────────┘");
                Console.ResetColor();
                Console.ResetColor();
                Console.WriteLine("\t\t\t\tPress any key to continue...");
                Console.ReadKey();
                MainMenu(E,D,P);
            }
            else
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\t\t\t\t┌───────────────────────────────────────────────────────┐");
                Console.WriteLine("\t\t\t\t│        Invalid credentials, please try again.         │");
                Console.WriteLine("\t\t\t\t└───────────────────────────────────────────────────────┘");
                Console.ResetColor();
                Console.ResetColor();
                Console.WriteLine("\t\t\t\tPress any key to exit...");
                Console.ReadKey();
                Environment.Exit(0);
            }

            Console.WriteLine();
        }
        public void MainMenu(Employee[] E, Department[] D, Project[] P)
        {
            Console.Clear();
            Console.WriteLine("\t\t\t\tChoose From the Following Menu");
            Console.WriteLine("\t\t\t\t──────────────────────────────────");
            Console.WriteLine();
            Console.WriteLine("\t\t\t\t┌───────────────────────────────────────────────────────┐");
            Console.WriteLine($"\t\t\t\t│                   (1) Employee                        │");
            Console.WriteLine($"\t\t\t\t│                   (2) Department                      │");
            Console.WriteLine($"\t\t\t\t│                   (3) Projects                        │");
            Console.WriteLine($"\t\t\t\t│                   (4) Exit                            │");
            Console.WriteLine("\t\t\t\t└───────────────────────────────────────────────────────┘");
            Console.WriteLine();
            Console.Write("\t\t\t\tPlease Enter Your Choice: ");

            // Take input and Validate
            int choice = int.Parse(Console.ReadLine());
            while (choice <= 0 || choice > 4)
            {

                Console.WriteLine("Invalid choice, please try again.");
                Console.Write("Please Enter Your Choice: ");
                choice = int.Parse(Console.ReadLine());

            }

            MenuHandler menuHandler = new MenuHandler();
            menuHandler.HandelMainMenu(choice, E,  D,P);




        }


        public static void EmployeeMenu(Employee[] E, Department[] D, Project[] P)
        {
            Console.Clear();
            Console.WriteLine("\t\t\t\tChoose From the Following Menu");
            Console.WriteLine("\t\t\t\t──────────────────────────────────");
            Console.WriteLine();
            Console.WriteLine("\t\t\t\t┌───────────────────────────────────────────────────────┐");
            Console.WriteLine($"\t\t\t\t│               (1) Add Employee                        │");
            Console.WriteLine($"\t\t\t\t│               (2) Get All Employees                   │");
            Console.WriteLine($"\t\t\t\t│               (3) Update Employee                     │");
            Console.WriteLine($"\t\t\t\t│               (4) Get Employee BY ID                  │");
            Console.WriteLine($"\t\t\t\t│               (5) Return to Main Menu                 │");
            Console.WriteLine("\t\t\t\t└───────────────────────────────────────────────────────┘");
            Console.WriteLine();
            Console.Write("\t\t\t\tPlease Enter Your Choice: ");


            // Take input and Validate
            int choice = int.Parse(Console.ReadLine());
            while (choice <= 0 || choice > 5)
            {

                Console.WriteLine("Invalid choice, please try again.");
                Console.Write("Please Enter Your Choice: ");
                choice = int.Parse(Console.ReadLine());

            }

            MenuHandler menuHandler = new MenuHandler();
            menuHandler.HandleEmployeeMenu(choice, E, D, P);
        }


        public static void DepartmentMenu(Employee[] E, Department[] D, Project[] P)
        {
            Console.Clear();
            Console.WriteLine("\t\t\t\tChoose From the Following Menu");
            Console.WriteLine("\t\t\t\t──────────────────────────────────");
            Console.WriteLine();
            Console.WriteLine("\t\t\t\t┌───────────────────────────────────────────────────────┐");
            Console.WriteLine($"\t\t\t\t│              (1) Add Department                       │");
            Console.WriteLine($"\t\t\t\t│              (2) Get All Department                   │");
            Console.WriteLine($"\t\t\t\t│              (3) Update Department                    │");
            Console.WriteLine($"\t\t\t\t│              (4) Get Department BY ID                 │");
            Console.WriteLine($"\t\t\t\t│              (5) Return to Main Menu                  │");
            Console.WriteLine("\t\t\t\t└───────────────────────────────────────────────────────┘");
            Console.WriteLine();
            Console.Write("\t\t\t\tPlease Enter Your Choice: ");

            int choice = int.Parse(Console.ReadLine());
            while (choice <= 0 || choice > 5)
            {
                Console.WriteLine("Invalid choice, please try again.");
                Console.Write("Please Enter Your Choice: ");
                choice = int.Parse(Console.ReadLine());
            }
            MenuHandler menuHandler = new MenuHandler();
            menuHandler.HandleDepartmentMenu(choice,E,D,P);

        }


        public static void ProjectMenu(Employee[] E, Department[] D, Project[] P)
        {
            Console.Clear();
            Console.WriteLine("\t\t\t\tChoose From the Following Menu");
            Console.WriteLine("\t\t\t\t──────────────────────────────────");
            Console.WriteLine();
            Console.WriteLine("\t\t\t\t┌───────────────────────────────────────────────────────┐");
            Console.WriteLine($"\t\t\t\t│              (1) Add Project                          │");
            Console.WriteLine($"\t\t\t\t│              (2) Get All Project                      │");
            Console.WriteLine($"\t\t\t\t│              (3) Update Project                       │");
            Console.WriteLine($"\t\t\t\t│              (4) Get Project BY ID                    │");
            Console.WriteLine($"\t\t\t\t│              (5) Return to Main Menu                  │");
            Console.WriteLine("\t\t\t\t└───────────────────────────────────────────────────────┘");
            Console.WriteLine();
            Console.Write("\t\t\t\tPlease Enter Your Choice: ");

            int choice = int.Parse(Console.ReadLine());
            while (choice <= 0 || choice > 5)
            {
                Console.WriteLine("Invalid choice, please try again.");
                Console.Write("Please Enter Your Choice: ");
                choice = int.Parse(Console.ReadLine());
            }
            MenuHandler menuHandler = new MenuHandler();
            menuHandler.HandleProjectMenu(choice,  E, D, P);


        }

        public void GetAll(string type, Employee[] E, Department[] D, Project[] P)
        {
            if (type == "Emp")
            {
                Console.Clear();

                // Get All Employees
                Console.WriteLine("\t───────────────────────────────────────────────────────────────────────────────────────────────────────────────");
                Console.WriteLine("\t┌─────┬─────────────┬─────────────┬───────────────────┬────────────┬───────────┬───────────────┬───────────────┐");
                Console.WriteLine("\t│ ID  │ First Name  │ Last Name   │      Position     │ Department │ Project   │   Salary      │  Birth Date   │");
                Console.WriteLine("\t├─────┼─────────────┼─────────────┼───────────────────┼────────────┼───────────┼───────────────┼───────────────┤");

                for (int i = 0; i < E.Length; i++)
                {
                    if (E[i] == null)
                    {
                        Console.WriteLine("\t└─────┴─────────────┴─────────────┴───────────────────┴────────────┴───────────┴───────────────┴───────────────┘");
                        break;
                    }
                    else
                    {
                        Employee emp = E[i];
                        Console.WriteLine($"\t│ {emp.ID,-3} │ {emp.FirstName,-11} │ {emp.LastName,-11} │ {emp.Position,-17} │ {emp.Department,-10} │ {emp.Project,-9} │ {emp.Salary,13} │ {emp.BirthDate:yyyy-MM-dd}    │");
                    }
                }
                Console.WriteLine("\t└─────┴─────────────┴─────────────┴───────────────────┴────────────┴───────────┴───────────────┴───────────────┘");


                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.Write("\t\t\t\tPress Any key to Return to Main Menu : ");
                Console.ReadKey();
                Console.Clear();
                EmployeeMenu(E, D, P);

            }
            else if (type == "Dep")
            {
                Console.Clear();
                // For Department
                Console.WriteLine("\t\t──────────────────────────────────────────────────────────────────────────────────────────");
                Console.WriteLine("\t\t┌─────┬───────────────────┬───────────────────────────────────────────────┬─────────────┐");
                Console.WriteLine("\t\t│ ID  │ Department Name   │ Description                                   │ Employees   │");
                Console.WriteLine("\t\t├─────┼───────────────────┼───────────────────────────────────────────────┼─────────────┤");
                for (int i = 0; i < D.Length; i++)
                {
                    if (D[i] == null)
                    {
                        Console.WriteLine("\t\t└─────┴───────────────────┴───────────────────────────────────────────────┴─────────────┘");
                        break;
                    }
                    else
                    {
                        Department dep = D[i];
                        int employeeCount = E.Count(emp => emp != null && emp.Department == dep.Name);
                        Console.WriteLine($"\t\t│ {dep.Id,-3} │ {dep.Name,-17} │ {dep.Description,-45} │ {employeeCount,-11} │");
                    }
                }
                Console.WriteLine("\t\t└─────┴───────────────────┴───────────────────────────────────────────────┴─────────────┘");

                Console.WriteLine();
                Console.WriteLine();
                Console.Write("\t\tPress Any key to Return to Main Menu : ");
                Console.ReadKey();
                Console.Clear();
                DepartmentMenu(E, D, P);

            }
            else if (type == "Pro")
            {
                Console.Clear();
                // For Project
                Console.WriteLine("\t\t─────────────────────────────────────────────────────────────────────────────────────────────────");
                Console.WriteLine("\t\t┌─────┬───────────────────┬─────────────────────────────────────┬───────────────┬─────────────┐");
                Console.WriteLine("\t\t│ ID  │ Project Name      │ Description                         │ Duration      │ Members     │");
                Console.WriteLine("\t\t├─────┼───────────────────┼─────────────────────────────────────┼───────────────┼─────────────┤");
                for (int i = 0; i < P.Length; i++)
                {
                    if (P[i] == null)
                    {
                        Console.WriteLine("\t\t└─────┴───────────────────┴─────────────────────────────────────┴───────────────┴───────────┘");
                        break;
                    }
                    else
                    {
                        Project pro = P[i];
                        int memberCount = E.Count(emp => emp != null && emp.Project == pro.Name);
                        Console.WriteLine($"\t\t│ {pro.Id,-3} │ {pro.Name,-17} │ {pro.Description,-35} │ {(pro.EndDate - pro.StartDate)} │ {memberCount,-9}   │");
                    }
                }
                Console.WriteLine("\t\t└─────┴───────────────────┴─────────────────────────────────────┴───────────────┴───────────┘");
                Console.WriteLine();
                Console.WriteLine();
                Console.Write("\t\tPress Any key to Return to Main Menu : ");
                Console.ReadKey();
                Console.Clear();
                ProjectMenu(E, D, P);

            }
        }
    }
}
