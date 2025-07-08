namespace D2_T2_MultiplicationTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Write a C# program that prints a multiplication table from 1 to 12.
            // Created by Mohamed Nabil

            for (byte i =1; i<=12; i++)
            {
                for (byte j = 1; j <= 12; j++)
                {
                    // Console.Write($" {i,2}*{j,2}={i*j,3} ");
                    string entry = $"{i}*{j}={i * j}";
                    Console.Write(entry.PadRight(10)); // Adjust width to align columns
                }
                Console.WriteLine(); // Move to the next line after each row
            }
        }
    }
}
