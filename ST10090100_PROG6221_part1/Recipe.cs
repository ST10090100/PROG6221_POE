using System;
using System.Collections.Generic;
using System.Text;

namespace ST10090100_PROG6221_part1
{
    class Recipe
    {
        //class objects for the recipe class
        private string[] ingredients;
        private float[] quantities;
        private string[] units;
        private string[] steps;

        //The input code for the recipe section of the app
        public Recipe()
        {
            Console.Write("Enter the number of ingredients: ");
            int numIngredients = int.Parse(Console.ReadLine());

            ingredients = new string[numIngredients];
            quantities = new float[numIngredients];
            units = new string[numIngredients];

            for (int i = 0; i < numIngredients; i++)
            {
                Console.Write("Enter the name of ingredient {0}: ", i + 1);
                ingredients[i] = Console.ReadLine();

                Console.Write("Enter the quantity of {0}: ", ingredients[i]);
                quantities[i] = float.Parse(Console.ReadLine());

                Console.Write("Enter the unit of measurement for {0}: ", ingredients[i]);
                units[i] = Console.ReadLine();
            }

            Console.Write("Enter the number of steps: ");
            int numSteps = int.Parse(Console.ReadLine());

            steps = new string[numSteps];

            for (int i = 0; i < numSteps; i++)
            {
                Console.Write("Enter step {0}: ", i + 1);
                steps[i] = Console.ReadLine();
            }
        }
        //Display full recipe with steps on screen
        public void Display()
        {
            Console.WriteLine("Ingredients:");

            for (int i = 0; i < ingredients.Length; i++)
            {
                Console.WriteLine("{0} {1} {2}", quantities[i], units[i], ingredients[i]);
            }

            Console.WriteLine("Steps:");

            for (int i = 0; i < steps.Length; i++)
            {
                Console.WriteLine("{0}. {1}", i + 1, steps[i]);
            }
        }
        //The scalling of units by factors of half,double or triple
        public void Scale(float factor)
        {
            for (int i = 0; i < quantities.Length; i++)
            {
                quantities[i] *= factor;
            }
        }

        public void Reset()
        {
            // Reset quantities to their the original values
            // This assumes that the original quantities are stored in a separate array
            float[] originalQuantities = new float[quantities.Length];
            Array.Copy(quantities, originalQuantities, quantities.Length);
            quantities = originalQuantities;
        }

        public void Clear()
        {
            // Clears all the data by creating new empty arrays
            ingredients = new string[0];
            quantities = new float[0];
            units = new string[0];
            steps = new string[0];

        }
    }
}
