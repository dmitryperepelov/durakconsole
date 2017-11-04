using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThrowingDurakConsole
{
    public class Deck
    {
        public Card[] deck = new Card[36];
        int trump;

        public Deck()
        {
            var newTrump = new Random();
            trump = newTrump.Next(4);
            for (int i = 0; i < 36; i++)
            {
                deck[i] = new Card
                {
                    Cardid = i,
                    WhereCard = 0,
                    Value = (i - (i % 4)) / 4
                };
                switch (i + 1)
                {
                    case 1:
                    case 5:
                    case 9:
                    case 13:
                    case 17:
                    case 21:
                    case 25:
                    case 29:
                    case 33: deck[i].Suit = 0; break;
                    case 2:
                    case 6:
                    case 10:
                    case 14:
                    case 18:
                    case 22:
                    case 26:
                    case 30:
                    case 34: deck[i].Suit = 1; break;
                    case 3:
                    case 7:
                    case 11:
                    case 15:
                    case 19:
                    case 23:
                    case 27:
                    case 31:
                    case 35: deck[i].Suit = 2; break;
                    case 4:
                    case 8:
                    case 12:
                    case 16:
                    case 20:
                    case 24:
                    case 28:
                    case 32:
                    case 36: deck[i].Suit = 3; break;
                }
                if (deck[i].Suit == trump)
                    deck[i].IsTrump = true;
                else
                    deck[i].IsTrump = false;
            }
        }

        public void Shuffle()
        {
            void Swap(ref Card first, ref Card second)
            {
                Card temp = first;
                first = second;
                second = temp;
            }

            var rndValue = new Random();
            for (int i = 35; i > 0; i--)
            {
                int value = rndValue.Next(0, i);
                Swap(ref deck[i], ref deck[value]);
            }

        }   
    }
}
