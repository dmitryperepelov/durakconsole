using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThrowingDurakConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var g = new Game();
            var l = new Deck();
            g.TestShuffle();

            g.TestGiveCard();

            for (int i = 0; i < l.deckList.Count - 1; i++)
                Console.WriteLine(l.deckList[i]);
        }
    }
}
