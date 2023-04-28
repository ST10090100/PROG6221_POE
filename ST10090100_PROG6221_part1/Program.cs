using System;

namespace ST10090100_PROG6221_part1
{
    class Program
    {//The main program running the application
        static void Main(string[] args)
        {
            Recipe recipe = new Recipe();

            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Enter a command:");
                Console.WriteLine("1. Display recipe");
                Console.WriteLine("2. Scale recipe");
                Console.WriteLine("3. Reset quantities");
                Console.WriteLine("4. Clear recipe");
                Console.WriteLine("5. Exit");

                //The input code for the program
                string input = Console.ReadLine();

                if (input == "1")
                {
                    recipe.Display();
                }
                else if (input == "2")
                {
                    Console.Write("Enter the scaling factor (0.5, 2, or 3): ");
                    float factor = float.Parse(Console.ReadLine());
                    recipe.Scale(factor);
                }
                else if (input == "3")
                {
                    recipe.Reset();
                }
                else if (input == "4")
                {
                    recipe.Clear();
                    recipe = new Recipe();
                }
                else if (input == "5")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid command.");
                }
            }
        }
    }
}