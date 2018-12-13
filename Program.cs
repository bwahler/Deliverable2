using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripPlanner
{
    class Program
    {
        static void Main(string[] args)
        {
            // Greeting to user
            Console.WriteLine("Welcome to the Travel Planner");
            Console.WriteLine("Please enter first name");
            string name = Console.ReadLine();
            
            // Prompt of travel activity with validation
            while (true)
            {
                Console.WriteLine("Hello " + name + "," + " please choose the type of activity you would like:");
                try
                {
                    Console.WriteLine("Please select a number 1-4:");
                    Console.WriteLine("1. Action");
                    Console.WriteLine("2. Chill");
                    Console.WriteLine("3. Danger");
                    Console.WriteLine("4. Good Food");
                    int optionNumber = int.Parse(Console.ReadLine());

                    // Next question for number of people traveling
                    Console.WriteLine("How many people will be traveling");
                    int numberOfPeople = int.Parse(Console.ReadLine());

                    // Output based on user response
                    if (optionNumber == 1 && numberOfPeople == 0)
                    {
                        Console.WriteLine("If you are in the mood for a action, then you should go stock car racing and be transported there in a pair of sneakers.");
                    }
                    else if (optionNumber == 1 && numberOfPeople < 5 && numberOfPeople > 0)
                    {
                        Console.WriteLine("If you are in the mood for a action, then you should go stock car racing and be transported there in a sedan.");
                    }
                    else if (optionNumber == 1 && numberOfPeople < 11 && numberOfPeople > 4)
                    {
                        Console.WriteLine("If you are in the mood for a action, then you should go stock car racing and be transported there in a Volkswagen bus.");
                    }
                    else if (optionNumber == 1 && numberOfPeople > 10)
                    {
                        Console.WriteLine("If you are in the mood for a action, then you should go stock car racing and be transported there in an airplane.");
                    }
                    else if (optionNumber == 2 && numberOfPeople == 0)
                    {
                        Console.WriteLine("If you are in the mood for a chill day, then you should go to the lake and be transported there in a pair of sneakers.");
                    }
                else if (optionNumber == 2 && numberOfPeople < 5 && numberOfPeople > 0)
                    {
                        Console.WriteLine("If you are in the mood for a chill day, then you should go to the lake and be transported there in a sedan.");
                    }
                    else if (optionNumber == 2 && numberOfPeople < 11 && numberOfPeople > 4)
                    {
                        Console.WriteLine("If you are in the mood for a chill day, then you should go to the lake and be transported there in a Volkswagen Bus.");
                    }
                    else if (optionNumber == 2 && numberOfPeople > 10)
                    {
                        Console.WriteLine("If you are in the mood for a chill day, then you should go to the lake and be transported there in an airplane.");
                    }
                    else if (optionNumber == 3 && numberOfPeople == 0)
                    {
                        Console.WriteLine("If you are in the mood for some danger, then you should go skydiving and be transported there in a pair of sneakers.");
                    }
                    else if (optionNumber == 3 && numberOfPeople < 5 && numberOfPeople > 0)
                    {
                        Console.WriteLine("If you are in the mood for some danger, then you should go skydiving and be transported there in a sedan.");
                    }
                    else if (optionNumber == 3 && numberOfPeople < 11 && numberOfPeople > 4)
                    {
                        Console.WriteLine("If you are in the mood for some danger, then you should go skydiving and be transported there in a Volkswagen bus.");
                    }
                    else if (optionNumber == 3 && numberOfPeople > 10)
                    {
                        Console.WriteLine("If you are in the mood for some danger, then you should go skydiving and be transported there in an airplane.");
                    }
                    else if (optionNumber == 4 && numberOfPeople == 0)
                    {
                        Console.WriteLine("If you are in the mood for some good food, then you should go Duff's and be transported there in a pair of sneakers.");
                    }
                    else if (optionNumber == 4 && numberOfPeople < 5 && numberOfPeople > 0)
                    {
                        Console.WriteLine("If you are in the mood for some good food, then you should go Duff's and be transported there in a sedan.");
                    }
                    else if (optionNumber == 4 && numberOfPeople < 11 && numberOfPeople > 4)
                    {
                        Console.WriteLine("If you are in the mood for some good food, then you should go Duff's and be transported there in a Volkswagen bus.");
                    }
                    else if (optionNumber == 4 && numberOfPeople > 10)
                    {
                        Console.WriteLine("If you are in the mood for some good food, then you should go Duff's and be transported there in an airplane.");
                    }
                    else
                    {
                        Console.WriteLine("This is not a valid input");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("This is not an accepted input");
                }

                // Prompts for user continue or to end program
                Console.WriteLine("Would you like to continue? (y/n)");
                string userContinue = Console.ReadLine().ToLower();
                if (userContinue == "y")
                {
                    continue;
                }
                else if (userContinue == "n")
                {
                    Console.WriteLine("Goodbye, " + name);
                    break;
                }
                else
                {
                    Console.WriteLine("Sorry, that is not a valid input! Please try again (y/n)");
                    userContinue = Console.ReadLine().ToLower();
                }
            }
        }
    }
}
