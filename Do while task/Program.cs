namespace Do_while_task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;

            do
            {
                Console.Write("Enter a number: ");
                number = Convert.ToInt32(Console.ReadLine());

                if (!(number >= 10 && number <= 20))
                {
                    Console.WriteLine("Something went wrong.Do you want to continue?");
                    string answer = Console.ReadLine();
                    answer = answer.ToUpper();
                    if (answer == "YES")
                    {
                        continue;

                    }
                }
                else
                {
                    if (number % 2 == 0)
                    {
                        Console.WriteLine($"The number {number} is even");
                    }
                    else
                    {
                        Console.WriteLine($"The number {number} is odd");
                    }
                }
                break;
            } while (!(number >= 10 && number <= 20));
        }
    }
}