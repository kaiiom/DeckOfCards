using System;
using System.Collections.Generic;

namespace DeskOfCards
{
    class Program
    {
        static void Main(string[] args)
        {
            //main program
            Deck cardDeck = new Deck();

            //main menu
            char input = Menu();

        }

        static char Menu()
        {
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1. Display a card from ID");

            char userKey = Console.ReadKey().KeyChar;
            return userKey;
        }
    }
}
