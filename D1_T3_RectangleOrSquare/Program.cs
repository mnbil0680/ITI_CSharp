namespace D1_T3_RectangleOrSquare
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Write a C# program that checks if a rectangle with given length and width is a square.
            //Created by Mohamed Nabil

            Console.Write("Please Enter the Length of the Rectangle: ");
            int Length = int.Parse(Console.ReadLine());

            Console.Write("Please Enter the Width of the Rectangle: ");
            int Width = int.Parse(Console.ReadLine());

            if (Length == Width)
            {
                Console.WriteLine("The Rectangle is a Square");
            }
            else
            {
                Console.WriteLine("The Rectangle is not a Square");
            }
        }
    }
}
