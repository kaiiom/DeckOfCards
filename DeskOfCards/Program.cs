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
            bool exit = false;

            //main menu
            do
            {
                char input = Menu();
                switch (input)
                {
                    case ('1'):
                        GetCard(cardDeck);
                        break;
                    case ('2'):
                        exit = true;
                        break;

                }
            } while (exit == false);
        }

        //functions
        static char Menu()
        {
            Console.Clear();
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1. Display a card from ID");
            Console.WriteLine("2. Exit");

            char userKey = Console.ReadKey().KeyChar;
            return userKey;
        }

        //procedures
        static void GetCard(Deck cardDeck)
        {
            //displays which card got entered
            Console.Clear();
            Console.Write("Enter card number (1-52): ");
            int cardNum = ((int.Parse(Console.ReadLine()) - 1));

            //convert face to string if needs be
            string face = cardDeck.Cards[cardNum].face.ToString();
            string suit = cardDeck.Cards[cardNum].suit;

            switch (face)
            {
                case "1":
                    face = "Ace";
                    break;
                case "11":
                    face = "Jack";
                    break;
                case "12":
                    face = "Queen";
                    break;
                case "13":
                    face = "King";
                    break;
            }

            Console.WriteLine();
            Console.WriteLine("{0} of {1}", face, suit);
            Console.ReadKey();
            
        }

    }
}
