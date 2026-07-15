
namespace loops_collections
{
    internal class AverageCalculator
    {
        internal void AveragesWithWhile()
        {
            throw new NotImplementedException();
        }

        internal void AveragesWithFor()
        {
            throw new NotImplementedException();
        }

        internal void AveragesWithDoWhile()
        {
            double total = 0.0;
            int count = 0;
            string input;

            do
            {
                Console.Write("Enter  number, or Q to quit: ");
                input = Console.ReadLine();

                if (input.ToUpper() != "Q")
                {
                    total += double.Parse(input);
                    count++;
                }
            } while (input.ToUpper() != "Q");

        
            if (count == 0)
            {
                Console.WriteLine("You didn't enter any numbers");
            }
            else
            {
                Console.WriteLine($"The average of those numbers is {total / count}");
            }

        }
    }
}