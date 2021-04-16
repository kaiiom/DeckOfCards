using System;
using System.Collections.Generic;

namespace DeskOfCards
{
    public class Deck
    {
        //fields of the card
        public const int count = 52;
        public Card card = new Card();
        //private Card[] cards = new Card[count];
        public LinkedList<Card> cards = new LinkedList<Card>();

        //properties, public facing side
        public LinkedList<Card> Cards
        {
            get { return cards; }
            set { this.cards = value; }
        }

        //constructors
        public Deck()
        {
            //for (int i = 0; i < count; i++)
            //{
            //    cards.AddLast(card);
            //    //cards[i] = card;
            //}

            //initialize the cards here
            //clubs 0 - 12
            //diamonds 13 - 25
            //hearts 26 - 38
            //spades 39 - 51

            //initialising numbers
            //1 = A, 11 = J, 12 = K, 13 = Q

            //clubs
            for (int j = 0; j <= 12; j++)
            {
                Card newCard = new Card();
                newCard.face = j + 1;
                newCard.suit = "clubs";

                //cards[j] = AddCard(newCard);
            }

            //diamonds
            for (int j = 13; j <= 25; j++)
            {
                Card newCard = new Card();
                newCard.face = j - 12;
                newCard.suit = "diamonds";

                //cards[j] = AddCard(newCard);
                cards.AddLast(AddCard(newCard));
            }

            //hearts
            for (int j = 26; j <= 38; j++)
            {
                Card newCard = new Card();
                newCard.face = j - 25;
                newCard.suit = "hearts";

                //cards[j] = AddCard(newCard);
                cards.AddLast(AddCard(newCard));
            }

            //spades
            for (int j = 39; j <= 51; j++)
            {
                Card newCard = new Card();
                newCard.face = j - 38;
                newCard.suit = "spades";

                //cards[j] = AddCard(newCard);
                cards.AddLast(AddCard(newCard));
            }
        }

        //methods
        public static Card AddCard(Card card)
        {
            Card newCard = new Card();
            newCard = card;
            return newCard;
        }
        
        public static void Shuffle(Card[] cards)
        {
            
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
