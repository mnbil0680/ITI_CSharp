namespace D1_T2_EvenOrOdd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Write a C# program that checks if a number entered by the user is even or odd
            //Created by Mohamed Nabil
            Console.Write("Please Enter a Number: ");
            int Numebr = int.Parse(Console.ReadLine());
            if (Numebr % 2 == 0)
            {
                Console.WriteLine("Your Number Is Even");
            }
            else
            {
                Console.WriteLine("Your Number Is Odd");
            }
        }
    }
}
