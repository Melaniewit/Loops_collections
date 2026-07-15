namespace loops_collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AverageCalculator calculator = new AverageCalculator();

            calculator.AveragesWithWhile();
            Console.WriteLine("==========");

            calculator.AveragesWithDoWhile();
            Console.WriteLine("==========");

            calculator.AveragesWithFor();
        }
    }
}