using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThrowingDurakConsole
{
    class Game
    {

        private int whoseTurn = 0; // переменная показывает, чей ход

        public int WhoseTurn { get; set; }

        public void GiveCard()
        {
            var player = new Player();
            var cpu = new ComputerPlayer();
            var deck = new Deck();

            for (int i = 0; i < 6; i++)
            {
                player.MyCards[i] = deck.deckList[deck.deckList.Count - 1];
                deck.deckList.RemoveAt(deck.deckList.Count - 1);
            }

            for (int i = 0; i < 6; i++)
            {
                cpu.CPUCARDS.Add(deck.deckList[deck.deckList.Count - 1]);
                deck.deckList.RemoveAt(deck.deckList.Count - 1);
            }
        }

        public void TestGiveCard()
        {
            Console.Clear();

            Console.ReadKey();

            var d = new Deck();
            var p = new Player();
            var cpu = new ComputerPlayer();

            d.Shuffle();
            GiveCard();
            for (int i = 0; i < p.MyCards.Count - 1; i++)
            {
                Console.Write(p.MyCards[i]);
                Console.WriteLine(" ");
            }
            Console.ReadKey();
            Console.WriteLine(" ");
    
            for (int i = 0; i < cpu.CPUCARDS.Count - 1; i++)
            {
                Console.Write(cpu.CPUCARDS[i]);
                Console.WriteLine(" ");
            }
        }

        public void TestShuffle()
        {
            var d = new Deck();
            // d.Shuffle();
            for (int i = 0; i < 36; i++)
            {
                Console.Write(d.deckList[i].Cardid);
                Console.Write(" ");
                Console.Write(d.deckList[i].Value);
                Console.Write(" ");
                Console.WriteLine(d.deckList[i].Suit);
            }

            Console.ReadKey();

            d.Shuffle();
            Console.Clear();
            for (int i = 0; i < 36; i++)
            {
                Console.Write(d.deckList[i].Cardid);
                Console.Write(" ");
                Console.Write(d.deckList[i].Value);
                Console.Write(" ");
                Console.WriteLine(d.deckList[i].Suit);
            }
            Console.ReadKey();

        }
    }
}
