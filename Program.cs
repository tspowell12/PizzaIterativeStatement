using System;

namespace PizzaIterativeStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("How many pizzas would you like to order? ");
                string input = Console.ReadLine();
                int pizza_amount = int.Parse(input);
                int i = pizza_amount;
                
                // An IF statement to determine if user input is between 1 and 15
                if ((pizza_amount > 0) && (pizza_amount <= 15))
                {

                    // My DoWhile loop
                    do
                    {
                        Console.WriteLine(pizza_amount + " pizzas were ordered. " + i + " more pizzas to go.");
                        i--;
                    }
                    while (i > 0);
                   

                    /*
                    // My WHILE loop
                    while (i > 0)
                    {
                        Console.WriteLine(pizza_amount + " pizzas were ordered. " + i + " more pizzas to go.");
                        i--;
                    }
                    */


                    /*
                    // My FOR loop
                    for (i = pizza_amount; i > 0; i--)
                    {
                        Console.WriteLine(pizza_amount + " pizzas were ordered. " + i +
                                          " more pizzas to go.");
                    }
                    */

                    Console.WriteLine("Order Complete!");
                    Console.WriteLine("Press any key to exit the program...");
                    Console.ReadKey(true);
                }
                else
                {
                    Console.WriteLine("Enter an order between 1 and 15 pizzas.");
                    Console.WriteLine("Press any key to exit the program and try again...");
                    Console.ReadKey(true);
                }
            }
            catch
            {
                Console.WriteLine("Please enter an integer value");
                Console.WriteLine("Press any key to exit and try again...");
                Console.ReadKey(true);
            }
        }
    }
}
