using CSharp_study;
using System;

namespace CSharp
{
    
    class Program
    {
        
        static void Main(string[] args)
        {
            string[] deck = new string[] 
            { "파이어볼", "기사", "궁수", "자이언트", "화살", "골렘", "마녀", "마법사" };
           
            DeckShuffle(ref deck);

            while (true)
            {
                ShowHand(deck);

                int cardIndexOf = ChooseCard(deck);

                ArrangeCard(deck, cardIndexOf);
            }
        }

        static void DeckShuffle(ref string[] deck)
        {
            Random random = new Random();
            deck = deck.OrderBy(x => random.Next()).ToArray();
        }

        static void ShowHand(string[] deck)
        {
            Console.Write("Hand : ");
            for (int i = 0; i < 4; i++){ Console.Write($"[{i}]{deck[i]} "); }
            Console.WriteLine($"\nNext Card : {deck[4]}");

        }

        static int ChooseCard(string[] deck)
        {
                string input = Console.ReadLine();
                int a = Int32.Parse(input);
                switch (a)
                {
                    case 0 :
                        return a;
                        break;
                    case 1 :
                        return a;
                        break;
                    case 2 :
                        return a;
                        break;
                    case 3 :
                        return a;
                        break;
                    default:
                        return -1;
                        break;
                }
        }

        static void ArrangeCard(string[] deck, int cardIndexOf)
        {
            string temp = deck[cardIndexOf];
            deck[cardIndexOf] = deck[4];
            deck[4] = deck[5];
            deck[5] = deck[6];
            deck[6] = deck[7];
            deck[7] = temp;
        }

        static void ShowDeck(string[] deck)
        {
            for (int i = 0; i < deck.Length; i++)
                Console.WriteLine(deck[i]);
        }
    }
}
