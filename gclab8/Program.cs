using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace gclab8
{
    class Program
    {
        static void Main(string[] args)
        {
            bool y = true;
            while (y)
            {
                string[] students = {"Natasha Allison", "Simon Schneider", "Kyle Silva", "Santiago Martin", "Gustavo Mcgee", "Ron Keller", "Meghan Burke", "Florence Carr", "Kari Frank", "Madeline Montgomery", "Laurie Wilkins", "Heather Hicks", "Eddie Alvarado", "Tasha Hart", "Rodolfo Waters", "Bryan Howell", "Mae Martinez", "Erica Collier", "Marcella Ramirez", "Valerie Blair" };
                string[] state = {"Montana - Helena", "Nebraska - Lincoln", " Nevada - Carson City", "New Hampshire - Concord", "New Jersey - Trenton", "New Mexico - Santa Fe", "New York - Albany", "North Carolina - Raleigh", "North Dakota - Bismarck", "Oklahoma - Oklahoma City", "Oregon - Salem", "Pennsylvania - Harrisburg", "Rhode Island - Providence", "South Carolina - Columbia", "South Dakota - Pierre", "Tennessee - Nashville", "Texas - Austin", "Vermont - Montpelier", "Virginia - Richmond", "Washington - Olympia" };
                string[] color = {"BabyPowder", "Banana", "Blueberry", "Bubble Gum", "Cedar Chest", "Cherry", "Grape Jelly Bean", "Leather Jacket", "Lemon", "Licorice", "Lilac", "Lime", "Lumber", "New Car", "Orange", "Peach", "Pine", "Dirt", "Smoke", "Shampoo" };

                Console.WriteLine("Welcome to the GC class of randomly generated students with randomly generated attributes." + "\n" + "Please enter 1-20 to learn about one of them!");
                string user = Console.ReadLine();

                if (IsNOW(user) && IsInRange(user))
                {
                    int userInt = int.Parse(user);
                    Console.WriteLine("You picked student " + students[userInt-1] + "!" + "\n" + "Would you like to know their favorite State & Capital city or their favorite '94-'95 Crayola Magic Scent crayon color?" + "\n" + "Please enter 'state' or 'color' for more!");
                    string userTwo = Console.ReadLine();

                    if (IsNOW(userTwo) && IsState(userTwo))
                    {
                        Console.WriteLine(state[userInt-1]);
                    }
                    
                    if (IsNOW(userTwo) && IsColor(userTwo))
                    {
                        Console.WriteLine(color[userInt-1]);
                    }
                }

                else
                {
                    Console.WriteLine("Sorry Bud, that is an invaild input");
                }
                
                //continue y/n
                bool invalid = true;
                while (invalid)
                {
                    Console.WriteLine("Try again partner? (y/n):");
                    ConsoleKeyInfo pressed = Console.ReadKey();
                    Console.WriteLine();
                    bool isY = pressed.Key == ConsoleKey.Y;
                    bool isN = pressed.Key == ConsoleKey.N;

                    invalid = !isY && !isN;
                    y = isY;
                }
            }
        }

        //method to check for null or white space
        static bool IsNOW(string input)
        {
            return !string.IsNullOrWhiteSpace(input);
        }
        
        //Method to catch 0 and out of range
        static bool IsInRange(string word)
        {
            int num;
            int.TryParse(word, out num);
            if (num > 0 && num <= 20 )
            {
                return true;
            }
            return false;
        }
        
        //did user enter requested text "state"
        static bool IsState(string input)
        {
            string lower = input.ToLower();
            if (lower == "state")
            {
                return true;
            }
            return false;
        }
        
        //did user enter requested text "color"
        static bool IsColor(string input)
        {
            string lower = input.ToLower();
            if (lower == "color")
            {
                return true;
            }
            return false;
        }
    }
}
