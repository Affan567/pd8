using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jack_game
{
    internal class Game
    {
        private Deck deck;
        private Player player;
        private Dealer dealer;

        public Game()
        {
            deck = new Deck();
            deck.Shuffle();
            player = new Player();
            dealer = new Dealer();
        }

        public void Start()
        {
            
            player.AddCard(deck.DrawCard());
            player.AddCard(deck.DrawCard());
            dealer.AddCard(deck.DrawCard());
            dealer.AddCard(deck.DrawCard());

            player.ShowHand("Player");
            dealer.ShowHand("Dealer");

            
            while (true)
            {
                Console.Write("Hit or Stand? (h/s): ");
                string choice = Console.ReadLine().ToLower();

                if (choice == "h")
                {
                    player.AddCard(deck.DrawCard());
                    player.ShowHand("Player");

                    if (player.CalculateScore() > 21)
                    {
                        Console.WriteLine("Player Busts! Dealer Wins.");
                        return;
                    }
                }
                else if (choice == "s")
                {
                    break;
                }
            }

            
            dealer.ShowHand("Dealer");
            while (dealer.ShouldDraw())
            {
                dealer.AddCard(deck.DrawCard());
                dealer.ShowHand("Dealer");
            }

            int playerScore = player.CalculateScore();
            int dealerScore = dealer.CalculateScore();

            
            Console.WriteLine($"Player Score: {playerScore}");
            Console.WriteLine($"Dealer Score: {dealerScore}");

            if (dealerScore > 21 || playerScore > dealerScore)
                Console.WriteLine("Player Wins!");
            else if (playerScore < dealerScore)
                Console.WriteLine("Dealer Wins!");
            else
                Console.WriteLine("It's a Tie!");
        }
    }
}
