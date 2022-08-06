using System;
using System.Collections.Generic;
using System.Linq;
namespace PracticeLinq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var games = new List<string>() {"Stalker", "The Witcher", "GTA", "Mario" };

            var videogm = games.Max();
            var sorted = games.OrderBy(x => x);
            games.Sort();
            foreach (var game in games)
            {
                Console.WriteLine(game);
            }
        }
    }
}
