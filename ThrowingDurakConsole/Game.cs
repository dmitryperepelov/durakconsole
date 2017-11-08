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

        Deck d = new Deck();
       // d.Shuffle();
            Player p = new Player();
        ComputerPlayer c = new ComputerPlayer();

        public void GiveCard()
        {
            
            Console.ReadKey();
            while (p.myCards.Count < 6)
            {
                p.myCards.Add(d.deckList[d.deckList.Count - 1]);
                d.deckList.RemoveAt(d.deckList.Count - 1);
            }
            while (c.CPUcards.Count < 6)
            {
                c.CPUcards.Add(d.deckList[d.deckList.Count - 1]);
                d.deckList.RemoveAt(d.deckList.Count - 1);
            }
        }

        public void TestGiveCard()
        {
            Console.Clear();

            Console.ReadKey();

            d.Shuffle();                                            // Здесь происходит тасовка! Перенести
            GiveCard();
            for (int i = 0; i < p.myCards.Count; i++)
            {
                Console.Write(p.myCards[i]);
                Console.WriteLine(" ");
            }
            Console.ReadKey();
            Console.WriteLine(" ");
    
            for (int i = 0; i < c.CPUcards.Count; i++)
            {
                Console.Write(c.CPUcards[i]);
                Console.WriteLine(" ");
            }
            Console.ReadKey();
        }

        public void TestShuffle()
        {
            var d = new Deck();
            
            d.Shuffle();
            
           for (int i = 0; i < 36; i++)
            {
                Console.WriteLine(d.deckList[i]);
            }
            Console.ReadKey();
        }

    }
}
