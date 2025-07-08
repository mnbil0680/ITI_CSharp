namespace D1_T1_PositiveOrNegative
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Write a C# program that checks if a number entered by the user is positive, negative
            // Created By Mohamwd Nabil

            Console.Write("Please Enter a Number: ");
            int Number = int.Parse(Console.ReadLine());
            if (Number > 0)
            {
                Console.WriteLine("Positive Number +");
            }
            else if (Number < 0)
            {
                Console.WriteLine("Negative Number -");
            }
            else
            {
                Console.WriteLine("Your Number Is Zero 0");
            }
            
        }
    }
}
