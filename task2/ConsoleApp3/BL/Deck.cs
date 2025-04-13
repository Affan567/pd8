using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.BL
{
    internal class Deck
    {

            private int count;
            private Card[] deck = new Card[52];

            // Constructor: Initializes a full deck of 52 cards (13 values × 4 suits)
            public Deck()
            {
                count = 0;
                for (int x = 1; x <= 4; x++)
                {       // Suits (1–4)
                    for (int y = 1; y <= 13; y++)
                    {   // Values (1–13)
                        deck[count] = new Card(y, x); // Create card (value, suit)
                        count++;
                    }
                }
            }

            // Shuffles the deck using the Fisher-Yates algorithm
            public void shuffle()
            {
                System.Random rand = new System.Random();
                Card temp;
                for (int i = 0; i < 52; i++)
                {
                    int num = rand.Next(0, 52);  // Random index
                    temp = deck[num];            // Swap cards
                    deck[num] = deck[i];
                    deck[i] = temp;
                }
                count = 52;  // Reset count after shuffling
            }

            // Deals the top card from the deck (returns null if empty)
            public Card dealCard()
            {
                if (count > 0)
                {
                    count--;
                    return deck[count];  // Return top card
                }
                else
                {
                    return null;          // Deck is empty
                }
            }

            // Returns the number of cards left in the deck
            public int cardsLeft()
            {
                return count;
            }
        }
    }
