using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jack_game
{
    internal class Player
    {
        public List<Card> Hand {
            get; private set; 
        } = new List<Card>();

        public virtual void AddCard(Card card)
        {
            Hand.Add(card);
        }

        public int CalculateScore()
        {
            int total = 0;
            int aceCount = 0;

            foreach (var card in Hand)
            {
                total += card.Value;
                if (card.Rank == "A")
                    aceCount++;
            }

            while (total > 21 && aceCount > 0)
            {
                total -= 10;
                aceCount--;
            }

            return total;
        }
        public void ShowHand(string playerName)
        {
            Console.WriteLine($"{playerName}'s Hand:");
            foreach (var card in Hand)
                Console.WriteLine(card);
            Console.WriteLine($"Total Score: {CalculateScore()}\n");
        }
    }
}
