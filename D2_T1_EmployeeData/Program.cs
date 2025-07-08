using System.ComponentModel.Design;

namespace D2_T1_EmployeeData
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Write a Program that Takes the following Data from the Employee and Validate them
            // ID        ==> Must be Positive Integer
            // Name      ==> Must be String and Not Empty and does not contain numbers
            // Age       ==> Must be Positive Integer and Less than 100 and Greater than 18
            // Salary    ==> Must be Positive Decimal and Greater than 0

            
            // Created by Mohamed Nabil
            Console.WriteLine("Welcome To Employee Apllication Program");
            Console.WriteLine("=======================================");

            #region ID
            Console.Write("Please Enter Your ID: ");
            int ID = int.Parse(Console.ReadLine());
            while (ID <= 0)
            {
                Console.Write("Invalid ID. Please enter a positive integer: ");
                ID = int.Parse(Console.ReadLine());
            }
            #endregion

            #region Name
            Console.Write("Please Enter Your Name: ");
            string Name = Console.ReadLine();
            for (int i  =0; i<Name.Length;i++)
            {

                #region Built-in C# Method (IsDigit)
                /*
                // this is a  Solution using built-in C# methods called IsDigit
                // Check if the character is a digit
                if (char.IsDigit(Name[i]))
                {
                    Console.Write("Invalid Name. Please enter a valid name (no numbers): ");
                    Name = Console.ReadLine();
                    i = -1; // to Start from the beginning == لف وارجع تاني 
                }
                */
                #endregion

                #region MySolution if-elseif---
                /*
                // This is my solution using if-else statements to check if the character is a digit

                if (Name[i] == '1')
                {
                    Console.Write("Invalid Name. Please enter a valid name (no numbers): ");
                    Name = Console.ReadLine();
                    i = -1;
                }
                else if (Name[i] == '2')
                {
                    Console.Write("Invalid Name. Please enter a valid name (no numbers): ");
                    Name = Console.ReadLine();
                    i = -1;
                }
                else if (Name[i] == '3')
                {
                    Console.Write("Invalid Name. Please enter a valid name (no numbers): ");
                    Name = Console.ReadLine();
                    i = -1;
                }
                else if (Name[i] == '4')
                {
                    Console.Write("Invalid Name. Please enter a valid name (no numbers): ");
                    Name = Console.ReadLine();
                    i = -1;
                }
                else if (Name[i] == '5')
                {
                    Console.Write("Invalid Name. Please enter a valid name (no numbers): ");
                    Name = Console.ReadLine();
                    i = -1;
                }
                else if (Name[i] == '6')
                {
                    Console.Write("Invalid Name. Please enter a valid name (no numbers): ");
                    Name = Console.ReadLine();
                    i = -1;
                }
                else if (Name[i] == '7')
                {
                    Console.Write("Invalid Name. Please enter a valid name (no numbers): ");
                    Name = Console.ReadLine();
                    i = -1;
                }
                else if (Name[i] == '8')
                {
                    Console.Write("Invalid Name. Please enter a valid name (no numbers): ");
                    Name = Console.ReadLine();
                    i = -1;
                }
                else if (Name[i] == '9')
                {
                    Console.Write("Invalid Name. Please enter a valid name (no numbers): ");
                    Name = Console.ReadLine();
                    i = -1;
                }
                */
                #endregion

                #region MySolution one If With More ||
                if (Name[i] == '1' ||
                    Name[i] == '2' ||
                    Name[i] == '3' ||
                    Name[i] == '4' ||
                    Name[i] == '5' ||
                    Name[i] == '6' || 
                    Name[i] == '7' ||
                    Name[i] == '8' ||
                    Name[i] == '9' )
                {
                    Console.Write("Invalid Name. Please enter a valid name (no numbers): ");
                    Name = Console.ReadLine();
                    i = -1;
                }

                #endregion

            }
            #endregion

            #region Age
            Console.Write("Please Enter Your Age: ");
            int Age = int.Parse(Console.ReadLine());
            while (Age <= 18 ||
                   Age > 80)
            {
                Console.Write("Invalid Age. Please enter a positive integer (18 - 80): ");
                Age = int.Parse(Console.ReadLine());
            }
            #endregion

            #region Salary
            Console.Write("Please Enter Your Salary: ");
            float Salary = float.Parse(Console.ReadLine());
            while (Salary <= 0)
            {
                Console.Write("Invalid Salary. Please enter a positive decimal number: ");
                Salary = float.Parse(Console.ReadLine());
            }
            #endregion

            #region Display Data
            Console.WriteLine("\nEmployee Data:");
            Console.WriteLine($"ID: {ID}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Salary: {Salary}"); 
            Console.WriteLine("Thank you for Using Our Application!");
            #endregion


            

        }
    }
}
