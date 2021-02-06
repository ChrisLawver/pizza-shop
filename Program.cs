using System;
using System.Collections.Generic;
using System.Text;

namespace Choose_Your_Class
{
    public class Program
    {
        
        public static void Main(string[] args)
        {

            Pizza pizza = new Pizza();
            Console.WriteLine("Welcome to the Pizza Console App!\n");
            Console.WriteLine("What Pizza Shop would you like to visit?");
            pizza.Name = Console.ReadLine();
            Console.WriteLine("What city are you in?");
            pizza.Location = Console.ReadLine();

            bool active = true;

            while (active == true)
            {
                Console.Clear();
                Console.WriteLine($"Welcome to {pizza.Name} in {pizza.Location}!\n");

                Console.WriteLine("What kind of pizza would you like?");
                Console.WriteLine("1. Choose the size of your pizza");
                Console.WriteLine("2. Choose the toppings you would like on your pizza");
                Console.WriteLine("3. Would you like stuffed crust?");
                Console.WriteLine("4. Check out");
                Console.WriteLine("5. Exit the shop");
                string userChoice = Console.ReadLine();

                switch (userChoice)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("Select a size: \n1. Small \n2. Medium \n3. Large");
                        string sizeChoice = Console.ReadLine();
                        switch (sizeChoice)
                        {
                            case "1":
                                pizza.SelectPizzaSize("Small");
                                break;
                            case "2":
                                pizza.SelectPizzaSize("Medium");
                                break;
                            case "3":
                                pizza.SelectPizzaSize("Large");
                                break;
                            default:
                                Console.WriteLine("Please enter a valid number");
                                break;
                        }
                        Console.WriteLine($"You selected a {pizza.Size} Pizza");
                        break;
                    case "2":
                        Console.Clear();
                        Console.WriteLine("How many toppings would you like?");
                        pizza.SelectNumberOfToppings(Convert.ToInt32(Console.ReadLine()));

                        for (int i = 0; i < pizza.NumberOfToppings; i++)
                        {
                            Console.Write("Select a topping : ");
                            pizza.toppings.Add(Console.ReadLine());
                        }

                        if (pizza.NumberOfToppings == 0)
                        {
                            Console.WriteLine("You ordered a cheese pizza with no toppings");
                        }
                        else
                        {
                            Console.WriteLine("You added the following toppings to your pizza: ");

                            for (int i = 0; i < pizza.NumberOfToppings; i++)
                            {
                                Console.WriteLine($"{i + 1}. {pizza.toppings[i]}");
                            }

                        }
                        break;
                    case "3":
                        Console.Clear();


                        Console.WriteLine("Would you like stuffed crust? \n1. Yes \n2. No");
                        string stuffedCrustChoice = Console.ReadLine();
                        switch (stuffedCrustChoice)
                        {
                            case "1":
                                pizza.SelectStuffedCrust();
                                Console.WriteLine("You chose stuffed crust");
                                break;
                            case "2":
                                Console.WriteLine("You chose no stuffed crust");
                                break;
                            default:
                                break;
                        }
                        break;
                    case "4":
                        Console.Clear();
                        if (pizza.Size == null)
                        {
                            Console.WriteLine("You need to select a size first");
                        }
                        else
                        {
                            if (pizza.toppings.Count == 0 && pizza.StuffedCrust == false)
                            {
                                Console.WriteLine($"You ordered a {pizza.Size} cheese pizza");
                            }
                            else if(pizza.toppings.Count == 0 && pizza.StuffedCrust == true)
                            {
                                Console.WriteLine($"You ordered a {pizza.Size} stuffed crust cheese pizza");
                            }
                            else if (pizza.toppings.Count > 0 && pizza.StuffedCrust == true)
                            {
                                Console.WriteLine($"You ordered a {pizza.Size} stuffed crust pizza with the following toppings: ");
                                for (int i = 0; i < pizza.NumberOfToppings; i++)
                                {
                                    Console.WriteLine($"{i + 1}. {pizza.toppings[i]}");
                                }
                            }
                            else
                            {
                                Console.WriteLine($"You ordered a {pizza.Size} pizza with the following toppings: ");
                                for (int i = 0; i < pizza.NumberOfToppings; i++)
                                {
                                    Console.WriteLine($"{i + 1}. {pizza.toppings[i]}");
                                }
                                
                            }
                            active = false;
                            Console.WriteLine($"\nYour total is { pizza.PriceOfPizza():C}");
                            Console.WriteLine("Enjoy your pizza!");
                        }
                        break;
                        case "5":
                            Console.Clear();
                            Console.WriteLine("Come back soon!");
                            active = false;
                            break;
                    default:
                        Console.WriteLine("Please enter a valid number");
                        break;
                }
                Console.WriteLine("\nPress any key to continue");
                Console.ReadKey();
                Console.Clear();

            }
        }
    }
}
