using System;
using System.Collections.Generic;

namespace DeskOfCards
{
    public class Card
    {
        //fields of the card
        public int face;
        public string suit;

        //properties, public facing side

        public int Face
        {
            get { return face; }
            set { this.face = value; }
        }

        public string Suit
        {
            get { return suit; }
            set { this.suit = value; }
        }


        public Card()
        {
            //default value
            face = 0;
            suit = "null";
        }

        //methods
        private string GetFace()
        {
            string face = "";

            return face;
        }

        public string GetDescription()
        {
            string description = "";

            return description;
        }
    }
}
