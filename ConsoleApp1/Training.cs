namespace ConsoleApp1
{
    internal class InClass
    {
        static int Side;

        static int Roll(int s)
        {
            Random rd = new Random();
            return rd.Next(1, s + 1);
        }
        static void Main(string[] args)
        {
            Console.Write("Enter the number of sides: ");
            Side = int.Parse(Console.ReadLine());
            Console.WriteLine("1. Kiet - 2. Minh - 3. Chien");
            Console.WriteLine($"Result of the rolling the Dice is {Roll(Side)} !");
        }
    }
}
