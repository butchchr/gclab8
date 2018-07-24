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
            string[] students = {"Natasha Allison", "Simon Schneider", "Kyle Silva", "Santiago Martin", "Gustavo Mcgee", "Ron Keller", "Meghan Burke", "Florence Carr", "Kari Frank", "Madeline Montgomery", "Laurie Wilkins", "Heather Hicks", "Eddie Alvarado", "Tasha Hart", "Rodolfo Waters", "Bryan Howell", "Mae Martinez","Erica Collier", "Marcella Ramirez", "Valerie Blair"};
            string[] stateCapital = { "Montana - Helena", "Nebraska - Lincoln", " Nevada - Carson City", "New Hampshire - Concord", "New Jersey - Trenton", "New Mexico - Santa Fe", "New York - Albany", "North Carolina - Raleigh", "North Dakota - Bismarck", "Oklahoma - Oklahoma City", "Oregon - Salem", "Pennsylvania - Harrisburg", "Rhode Island - Providence", "South Carolina - Columbia", "South Dakota - Pierre", "Tennessee - Nashville", "Texas - Austin", "Vermont - Montpelier", "Virginia - Richmond", "Washington - Olympia" };
            string[] color = { "BabyPowder", "Banana", "Blueberry", "Bubble Gum", "Cedar Chest", "Cherry", "Grape Jelly Bean", "Leather Jacket", "Lemon", "Licorice",  "Lilac", "Lime", "Lumber", "New Car", "Orange", "Peach", "Pine", "Dirt", "Smoke", "Shampoo"};

            Console.WriteLine("Welcome to the GC of student with random attributes. Please enter 1-20 to learn about one of them");
            string user = Console.ReadLine();
            
            int userInt = int.Parse(user);
            Console.WriteLine(students[userInt-1]);
            Console.WriteLine(stateCapital[userInt - 1]);
            Console.WriteLine(color[userInt - 1]);

            Console.WriteLine(students.Length);
            Console.WriteLine(stateCapital.Length);
            Console.WriteLine(color.Length);
            Console.ReadKey();
        }

        //method to check for null or white space
        static bool IsNOW(string input)
        {
            return !string.IsNullOrWhiteSpace(input);
        }
        
        //method to check valid range
        static bool isValidStudent (string name)
        {
            return Regex.IsMatch(name, (@"(\d{1,20})"));
        }
    }
}
