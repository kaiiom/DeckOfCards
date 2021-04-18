using System;
using System.Collections.Generic;
using System.Linq;

namespace DeskOfCards
{
    public class Deck
    {
        //fields of the card
        public int count;
        public Card card = new Card();
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
            //initialize the cards
            count = 52;

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

                cards.AddLast(AddCard(newCard));
            }

            //diamonds
            for (int j = 13; j <= 25; j++)
            {
                Card newCard = new Card();
                newCard.face = j - 12;
                newCard.suit = "diamonds";

                cards.AddLast(AddCard(newCard));
            }

            //hearts
            for (int j = 26; j <= 38; j++)
            {
                Card newCard = new Card();
                newCard.face = j - 25;
                newCard.suit = "hearts";

                cards.AddLast(AddCard(newCard));
            }

            //spades
            for (int j = 39; j <= 51; j++)
            {
                Card newCard = new Card();
                newCard.face = j - 38;
                newCard.suit = "spades";

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

        public void Shuffle()
        {
            //shuffle the deck

            //convert to array
            Card[] tempArray = new Card[count];
            tempArray = cards.ToArray();

            //shuffle the array
            Random rnd = new Random();
            tempArray = tempArray.OrderBy(x => rnd.Next()).ToArray();

            //convert back to linkedlist
            cards = new LinkedList<Card>(tempArray);
        }
    
        public void Cut()
        {
            //process varies depending if the number of cards odd/even
            if (count % 2 == 0)
            {
                Card[] tempArray = new Card[count];
                tempArray = cards.ToArray();
                int midpoint = count / 2;

                //bottom half in tempArray
                Card[] arrayLower = new Card[midpoint];
                for (int i = 0; i <= midpoint - 1; i++)
                {
                    arrayLower[i] = tempArray[i];
                }

                //top half in tempArray
                Card[] arrayHigher = new Card[midpoint];
                for (int i = midpoint; i <= count - 1; i++)
                {
                    arrayHigher[i - midpoint] = tempArray[i];
                }

                //put top half in lower half of temp array
                for (int i = 0; i <= midpoint - 1; i++)
                {
                    tempArray[i] = arrayHigher[i];
                }

                //put lower half into top half of temp array
                for (int i = midpoint; i <= count - 1; i++)
                {
                    tempArray[i] = arrayLower[i - midpoint];
                }

                //convert back to linkedlist
                cards = new LinkedList<Card>(tempArray);
            }
            else
            {
                Card[] tempArray = new Card[count];
                tempArray = cards.ToArray();
                int midpoint = (count / 2) - 1;

                //bottom half in tempArray
                Card[] arrayLower = new Card[midpoint + 1];
                for (int i = 0; i <= midpoint; i++)
                {
                    arrayLower[i] = tempArray[i];
                }

                //top half in tempArray
                Card[] arrayHigher = new Card[midpoint + 2];
                for (int i = midpoint + 1; i <= count - 1; i++)
                {
                    arrayHigher[i - (midpoint + 1)] = tempArray[i];
                }

                //put top half in lower half of temp array
                for (int i = 0; i <= midpoint; i++)
                {
                    tempArray[i] = arrayHigher[i];
                }

                //put lower half into top half of temp array
                for (int i = midpoint + 2; i <= count - 1; i++)
                {
                    tempArray[i] = arrayLower[i - (midpoint + 2)];
                }

                //convert back to linkedlist
                cards = new LinkedList<Card>(tempArray);
            }
        }

        public Card DealCard()
        {
            //deals the card at the top of the linkedlist
            Card outputCard = new Card();

            outputCard = cards.First();
            cards.RemoveFirst();
            count--;
            return outputCard;
        }
    }
}
