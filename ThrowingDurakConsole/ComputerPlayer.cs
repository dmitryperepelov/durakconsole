using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThrowingDurakConsole
{
    class ComputerPlayer
    {
        public List<int> CPUcards = new List<int>();

        //public List<int> CPUCards { get; set; }
        Deck deck;

        Game game;

        public void Attack()
        {
            if (game.tabel.Count == 0)
            {
                int minCard = CPUcards[0];
                for (int i = 0; i < CPUcards.Count - 1; i++)
                {
                    if (((minCard / 10) < (CPUcards[i] / 10)) && ((CPUcards[i] % 10) != deck.Trump))
                        minCard = CPUcards[i];
                }
                CPUcards.Remove(minCard);
                game.tabel.Add(minCard);
                Console.Write(minCard);
                Console.Write(" ");
            }
            else
            {
                for (int i = 0; i < CPUcards.Count - 1; i++)
                {
                    for (int j = 0; j < game.tabel.Count - 1; j++)
                    {
                        if ((CPUcards[i] == game.tabel[j]) && (CPUcards[i] != deck.Trump))
                        {
                            game.tabel.Add(CPUcards[i]);
                            Console.Write(CPUcards[i]);
                            Console.Write(" ");
                            CPUcards.RemoveAt(i);
                        }
                    }
                }
            }
        }

        public void Defence()
        {
            int minCard = CPUcards[0];
            bool beat = false;
            for (int i = 0; i < CPUcards.Count - 1; i++)
            {
                if ((game.tabel[game.tabel.Count - 1] / 10 < CPUcards[i] / 10) && 
                    (CPUcards[i] < minCard) && 
                    ((CPUcards[i] % 10) != deck.Trump))
                {
                    minCard = CPUcards[i];
                    beat = true;
                    game.tabel.Add(minCard);
                }
            }
            if (!beat)
            {
                for (int i = 0; i < CPUcards.Count - 1; i++)
                {
                    if (((game.tabel[game.tabel.Count - 1] % 10) != deck.Trump) ||
                        ((game.tabel[game.tabel.Count - 1] % 10) == deck.Trump) && 
                        ((CPUcards[i] / 10) > (game.tabel[game.tabel.Count - 1] / 10)))
                    {
                        beat = true;
                        game.tabel.Add(CPUcards[i]);
                    }
                }
            }
            if (!beat)
            {
                for (int i = 0; i < game.tabel.Count - 1; i++)
                    CPUcards.Add(game.tabel[i]);
            }
        }
    }
}
