using System;
using System.Collections.Generic;
using System.Linq;

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
                        DisplayAllCards(cardDeck);
                        break;
                    case ('3'):
                        ShuffleDeck(cardDeck);
                        break;
                    case ('4'):
                        DealACard(cardDeck);
                        break;
                    case ('5'):
                        CutTheDeck(cardDeck);
                        break;
                    case ('6'):
                        exit = true;
                        break;

                }
            } while (exit == false);
        }

        //functions
        static char Menu()
        {
            Console.Clear();
            Console.WriteLine("DEBUGGING");
            Console.WriteLine("1. Display a card from ID");
            Console.WriteLine("2. Display all cards");

            Console.WriteLine();
            Console.WriteLine("FEATURES");
            Console.WriteLine("3. Shuffle deck");
            Console.WriteLine("4. Deal cards");
            Console.WriteLine("5. Cut the deck");
            Console.WriteLine("6. Exit");

            char userKey = Console.ReadKey().KeyChar;
            return userKey;
        }

        static string ConvertToWord(string face)
        {
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
            return face;
        }

        //procedures
        static void GetCard(Deck cardDeck)
        {
            //displays which card got entered
            Console.Clear();
            Console.Write("Enter card number (1-52): ");
            int cardNum = ((int.Parse(Console.ReadLine()) - 1));

            //convert face to string if needs be
            string face = cardDeck.Cards.ElementAt(cardNum).face.ToString();
            string suit = cardDeck.Cards.ElementAt(cardNum).suit;

            face = ConvertToWord(face);

            Console.WriteLine("{0} of {1}", face, suit);
            Console.ReadKey();
        }

        static void DisplayAllCards(Deck cardDeck)
        {
            Console.Clear();
            int count = cardDeck.Cards.Count();
            string suit;
            string face;

            for (int i = 0; i <= count - 1; i++)
            {
                suit = cardDeck.Cards.ElementAt(i).suit.ToUpper();
                face = cardDeck.Cards.ElementAt(i).face.ToString();
                face = ConvertToWord(face).ToUpper();

                //Console.WriteLine("{0}, {1}, {2}", i + 1, suit, face);
                Console.WriteLine((i + 1).ToString().PadRight(5) + suit.PadRight(10) + face.PadRight(10));
            }
            Console.ReadKey();
        }

        private static void ShuffleDeck(Deck cards)
        {
            Console.Clear();
            cards.Shuffle();
            Console.WriteLine("✓ Shuffled the deck");
            Console.ReadKey();
        }

        private static void DealACard(Deck cards)
        {
            Console.Clear();
            Console.WriteLine("How many cards would you like to deal?");
            int numOfCards = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("✓ Dealt the top {0} cards", numOfCards);

            for (int i = 1; i <= numOfCards; i++)
            {
                Card dealtCard = cards.DealCard();

                //convert face to string if needs be
                string face = dealtCard.Face.ToString();
                string suit = dealtCard.Suit;
                face = ConvertToWord(face);

                Console.WriteLine("Card {0} of {1}", face, suit);
            }
            
            Console.ReadKey();
        }

        private static void CutTheDeck(Deck cards)
        {
            Console.Clear();

            cards.Cut();
            Console.WriteLine("✓ Cut the deck");

            Console.ReadKey();
        }
    }
}
