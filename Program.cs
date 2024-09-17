using System;
using System.Collections.Generic;
using System.ComponentModel.Design;

namespace Lists_Adkisson_Damien
{
    class Program
    {
        static void Main(string[] args)
        {
            /// List of the games.
            List<string> games = new List<string>
            {
                "CS:GO",
                "Halo 3",
                "Borderlands 3",
                "Fifa 22",
                "Minecraft"
            };
            /// 2 list of games.
            string[] otherGames = new string[]
            {
                "Tiny Tina's Wonderlands",
                "Farcry 3"
            };
            /// prints the list of games to line one.
            foreach (string game in games) 
            { 
               Console.WriteLine(game);
            }
            /// this counts the amount of games on the list.
            Console.WriteLine($"\nGames in list: {games.Count}");
            ///prints the numbers to the line.
            games.AddRange(otherGames);
            /// this counts the 2 line of games.
            Console.WriteLine($"\ngames in list:{games.Count}");

            /// prints Halo to the line of games.
            if (games.Contains("Halo")) 
            {
                Console.WriteLine("\nMASTER CHEIF IS IN IN THE HOUSE!!");
            }
            else
            {
                games.Add("Halo");
            }

            int myInt = 6;
            /// removes farcry for lines of games.
            if(myInt < games.Count)
            {
                games.RemoveAt(myInt);
            }
            else
            {
                Console.WriteLine("\nGame not found!");
            }

            /// shows all games to the the list.
            Console.WriteLine("ALL games in the list:");
            foreach (string game in games) 
            {
                Console.WriteLine(game);  
            }
            /// sorts the games in or oder.
            games.Sort();
            /// games sorted in order.
            Console.WriteLine("\nSorted games list:");
            foreach (string game in games) 
            { 
              Console.WriteLine(game);
            }

            string[] newList = new string[games.Count];

            games.CopyTo(newList);

            games.Clear();
            /// new list games.
            Console.WriteLine("New List:");
            foreach (string game in newList)
            {
                Console.WriteLine(game);
            }
        }
    }
}