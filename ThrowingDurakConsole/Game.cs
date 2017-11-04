using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThrowingDurakConsole
{
    class Game
    {
        public void TestShuffle()
        {
            var d = new Deck();
            // d.Shuffle();
            for (int i = 0; i < 36; i++)
            {
                Console.Write(d.deck[i].Cardid);
                Console.Write(" ");
                Console.Write(d.deck[i].Value);
                Console.Write(" ");
                Console.WriteLine(d.deck[i].Suit);
            }

            Console.ReadKey();

            d.Shuffle();
            Console.Clear();
            for (int i = 0; i < 36; i++)
            {
                Console.Write(d.deck[i].Cardid);
                Console.Write(" ");
                Console.Write(d.deck[i].Value);
                Console.Write(" ");
                Console.WriteLine(d.deck[i].Suit);
            }
            Console.ReadKey();

        }
    }
}
