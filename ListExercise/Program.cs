using System;
using System.Collections.Generic;

namespace ListExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] namesArray = new string[13]
                {
                "Ramon", "Grace", "Josh", "Joshua", "Antonio", "Jeremiah", "Nick", "Wendi", "Juliana", "Tommy", "Steve", "Nate", "Jeff"
                };
            List<string> names = new List<string>();
            names.AddRange(namesArray);

            string[] foodsArray = new string[13]
                {"burgers", "sweet potato fries", "falafel", "nalesniki", "focaccia barese", "burgers", "tacos", "salami", "tacos", "chicken curry", "mooncakes", "steak", "steak"};
            List<string> foods = new List<string>();
            foods.AddRange(foodsArray);

            string[] placesArray = new string[13]
                 {"Tigard, OR", "Mesa, AZ", "Baldwin, MI", "Novi, MI", "Beverly Hills, MI", "Crystal, MI", "Canton, MI", "Detroit, MI", "Denver, CO", "Raleigh, NC", "The Moon", "Berkley, MI", "Detroit, MI"};
            List<string> places = new List<string>();
            places.AddRange(placesArray);

            bool validInput = true;
            while (validInput)
            {
                try
                {
                    Console.WriteLine("Hello and Welcome to our C# class!");
                    Console.WriteLine("Which person would you like to learn more about? Please enter a number 0-12");
                    string choice = Console.ReadLine();
                    int number = Int32.Parse(choice);
                    Console.WriteLine($"Person {number} is {names[number]}");
                    Console.WriteLine($"Would you like to know more about {names[number]}?(y/n)");
                    string holder = Console.ReadLine();
                    string response = holder.ToLower();
                    if (response == "y")
                    {
                        Console.WriteLine(@"enter ""hometown"" or ""favorite food""");
                        string holder2 = Console.ReadLine();
                        string response2 = holder2.ToLower();
                        if (response2 == "hometown")
                        {
                            Console.WriteLine($"{names[number]} is from {places[number]}");
                        }
                        else if (response2 == "favorite food")
                        {
                            Console.WriteLine($"{names[number]} loves to eat {foods[number]}");
                        }
                        else
                        {
                            Console.WriteLine(@"I'm sorry you need to enter exactly ""hometown"" or ""favorite food"" exactly as written");
                            break;
                        }
                    }
                    else
                    {
                        validInput = false;

                    }
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("Hey! Please enter a number between 0 and 12 inclusively.");
                }
                catch (FormatException parseDontWorkOnLetters)
                {
                    Console.WriteLine(parseDontWorkOnLetters.Message);
                    Console.WriteLine("In English - I need a number. Thanks.");

                }
                catch (Exception exception) // same thing as a blank catch
                {
                    Console.WriteLine(exception.Message);
                    Console.WriteLine("Something went wrong! Let's try again");
                }
                Console.WriteLine("Would you like to learn about another student? (y/n)");
                string ans = Console.ReadLine();
                string answer = ans.ToLower();

                if(answer == "y")
                {
                    validInput = true;
                }
                else
                {
                    validInput = false;

                }
                
                
            }
        }
    }
}

