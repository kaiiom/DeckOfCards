using System;
using System.Collections.Generic;

namespace DeskOfCards
{
    public class Deck
    {
        //fields of the card
        public const int count = 52;
        private Card card = new Card();
        private Card[] cards = new Card[count];

        //properties, public facing side
        public Card[] Cards
        {
            get { return cards; }
            set { this.cards = value; }
        }

        //constructors
        public Deck()
        {
            for (int i = 0; i <= count - 1; i++)
            {
                cards[i] = card;
            }

            //initialize the cards here
            //clubs 0-12
            //diamonds 13-25
            //hearts 26-38
            //spades 39-51

            //initialising numbers
            //1 = A, 11 = J, 12 = K, 13 = Q
            for (int i = 0; i <= 3; i++)
            {
                //clubs
                if (i == 0)
                {
                    for (int j = 0; j <= 12; j++)
                    {
                        cards[j].face = j + 1;
                        cards[j].suit = "club";
                    }
                }

                //diamonds
                if (i == 1)
                {
                    for (int j = 0; j <= 12; j++)
                    {
                        cards[j].face = j + 1;
                        cards[j].suit = "diamond";
                    }
                }

                //hearts
                if (i == 2)
                {
                    for (int j = 0; j <= 12; j++)
                    {
                        cards[j].face = j + 1;
                        cards[j].suit = "heart";
                    }
                }

                //spades
                if (i == 3)
                {
                    for (int j = 0; j <= 12; j++)
                    {
                        cards[j].face = j + 1;
                        cards[j].suit = "spade";
                    }
                }
            }
        }

        //methods
        public static void AddCard(Card card)
        {
            //add a card to the deck
        }

        public static void Shuffle()
        {
            //shuffle the deck
        }

        public static void Cut()
        {
            //cut the deck
        }

        public static Card DealCard()
        {
            Card outputCard = new Card();

            return outputCard;
        }

        public static Card GetRandomCard()
        {
            Card outputCard = new Card();

            return outputCard;
        }

    }
}
