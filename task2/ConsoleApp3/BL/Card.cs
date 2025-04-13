using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.BL
{
    internal class Card
    {

        private int value;
        private int suit;

        public Card(int value, int suit)
        {
            this.value = value;
            this.suit = suit;
        }

        public int getvalue()
        {
            return value;
        }

        public int getsuit()
        {
            return suit;
        }
        public string getValueAsString()
        {
            if (value == 1)
            {
                return "Ace";
            }
            else if (value == 11)
            {
                return "Jack";
            }
            else if (value == 12)
            {
                return "Queen";
            }
            else if (value == 13)
            {
                return "King";
            }
            else
            {
                return value.ToString();
            }
        }
        public string getSuitAsString()
        {
            if (suit == 1)
            {
                return "Clubs";
            }
            else if (suit == 2)
            {
                return "Diamonds";
            }
            else if (suit == 3)
            {
                return "Spades";
            }
            else
            {
                return "Hearts";
            }
        }
        public string tostring()
        {
            return getValueAsString() + "of" + getSuitAsString(); 
        }
    }
}
