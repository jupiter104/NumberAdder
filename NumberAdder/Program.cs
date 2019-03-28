using System;

namespace NumberAdder
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;

            while (true)
            {
                Console.WriteLine("Enter a number to add or type 'ok' to exit");

                string input = Console.ReadLine();

                if (input == "ok")
                {
                    break;
                }

                double number = Convert.ToDouble(input);

                sum += number;

                Console.WriteLine(sum.ToString());
            }

            Console.Read();
        }
    }
}
