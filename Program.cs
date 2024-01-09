namespace exereciseMultiplicationTable
{
    internal class Program
    {
        public class WritingFunctions
        {


            public static void Multiplication(byte number, byte size = 12)
            {

                Console.Clear();
                for (int row = 1; row <= size; row++)
                {
                    Console.WriteLine($"{row} X {number} = {row * number}");
                }

            }
        }
        static void Main(string[] args)
        {
            while (true)
            {
                Console.BackgroundColor = ConsoleColor.Gray;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("Multiplication!");
                Console.WriteLine("Enter which number you want to multiplie:");
                if (byte.TryParse(Console.ReadLine(), out var number))
                {
                    Console.WriteLine("And how many rows do you wish to see?");
                    if (byte.TryParse(Console.ReadLine(), out var size))
                    {
                        WritingFunctions.Multiplication(number, size);
                    }
                }
                else 
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You have to enter a number.");
                    Console.ForegroundColor = ConsoleColor.Black;
                    continue; 
                }
            }
        }
    }
}
