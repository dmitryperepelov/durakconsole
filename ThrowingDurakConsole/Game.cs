using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThrowingDurakConsole
{
    class Game
    {
        public List<int> tabel = new List<int>();

        private int whoseTurn; // переменная показывает, чей ход

        public int WhoseTurn { get; set; }

        Deck d = new Deck();
        Player p = new Player();
        ComputerPlayer c = new ComputerPlayer();

        private int playerChoice;

        public int PlayerChoice { get; set; }

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

        public void GameProcess()
        {
            var rnd = new Random();
            WhoseTurn = rnd.Next(0, 1);
            while ((d.deckList.Count > 0) && ((p.myCards.Count > 0) || (c.CPUcards.Count > 0)))
            {
                GiveCard();
                if (WhoseTurn == 0)
                {
                    do
                    {
                        PlayerChoice = Console.Read();
                        c.Defence();
                    }
                    while (PlayerChoice != 0);
                }
                else
                {
                    do
                    {
                        c.Attack();
                        PlayerChoice = Console.Read();
                    }
                    while (PlayerChoice != 0);
                }
            }
                
        }

    }
}
