using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jack_game
{
    internal class Card
    {
        public string Suit 
        {             
            get; private set; 
        }
        public string Rank {
            get; private set; 
        }
        public int Value
        {
            get
            {
                if (int.TryParse(Rank, out int number))
                    return number;
                else if (Rank == "A")
                    return 11;
                else
                    return 10;
            }
        }

        public Card(string suit, string rank)
        {
            Suit = suit;
            Rank = rank;
        }

        public override string ToString()
        {
            return $"{Rank} of {Suit}";
        }

    }
}
