using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThrowingDurakConsole
{
    public class Deck
    {
        public int[] deck = new int[36];

        public List<int> deckList = new List<int>();

        private int trump;

        public int Trump { get; set; }

        public Deck()
        {
            int value = 1;
            int suit = 0;
            for (int i = 0; i < 36; i++)
            {
                if (value > 9)
                    value = 1;
                if (suit > 3)
                    suit = 0;
                int result = 10 * value + suit;
                deck[i] = result;
                value++;
                suit++;
            }
            
        }

        public void DeckListInit()
        {
            deckList.Clear();
            for (int i = 0; i < 36; i++)
            {
                deckList.Add(deck[i]);
            }
        }

        public void Shuffle()
        {
            void Swap(ref int first, ref int second)
            {
                int temp = first;
                first = second;
                second = temp;
            }

            var rndValue = new Random();

            for (int i = 35; i > 0; i--)
            {
                int value = rndValue.Next(0, i);
                Swap(ref deck[i], ref deck[value]);
            }

            Trump = rndValue.Next(0, 4);
            DeckListInit();
            deck = null;
            GC.Collect();
        } 
    }
}
