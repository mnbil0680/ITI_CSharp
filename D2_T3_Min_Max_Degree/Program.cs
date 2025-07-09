namespace D2_T3_Min_Max_Degree
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Please Enter Number Of Degrees: ");
            int Size = int.Parse(Console.ReadLine());
            int[] Degrees = new int[Size];
            int temp = 0;

            #region Fill Array
            // Fill Array With Degrees
            for (int i = 0; i < Size; i++)
            {
                Console.Write($"Please Enter Degree {i + 1} (From 0 To 100): ");
                temp = int.Parse(Console.ReadLine());
                // TODO Validate the input
                while (temp < 0 || temp > 100)
                {
                    Console.WriteLine("Invalid Degree");
                    Console.Write("Please Enter Degree {i + 1} (From 0 To 100): ");
                    temp = int.Parse(Console.ReadLine());
                }
                Degrees[i] = temp;

            }
            #endregion

            #region Calculate Sum, Max, Min, Avg and Median
            int Sum = 0;
            int Max = Degrees[0];
            int Min = Degrees[0];
            // Calculate Sum, Max, Min, Avg and Median
            for (int i = 0; i < Size; i++)
            {
                Sum += Degrees[i];
                if (Degrees[i] > Max)
                {
                    Max = Degrees[i];
                }
                if (Degrees[i] < Min)
                {
                    Min = Degrees[i];
                }
            }
            float Avg = (float)Sum / Size;
            Array.Sort(Degrees);
            float Median;
            int IndexOfMedian;

            if (Size % 2 == 0)
            {
                // Even
                IndexOfMedian = Size/2;
                int SumTwoNumbers = (Degrees[IndexOfMedian] + Degrees[IndexOfMedian - 1]);
                Median = (float)SumTwoNumbers / 2;
            }
            else
            {
                // Odd
                IndexOfMedian = Size / 2;
                Median = Degrees[IndexOfMedian];
            }
            #endregion

            #region Display Results
            Console.WriteLine("\nResults:");
            Console.WriteLine($"Min    ==> {Min}");
            Console.WriteLine($"Max    ==> {Max}");
            Console.WriteLine($"Sum    ==> {Sum}");
            Console.WriteLine($"Size   ==> {Size}");
            Console.WriteLine($"Avg    ==> {Avg}");
            Console.WriteLine($"IndexOfMedian ==> {IndexOfMedian}");
            Console.WriteLine($"Median ==> {Median}");
            #endregion



        }
    }
}
