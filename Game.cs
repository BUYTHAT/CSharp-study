using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_study
{
    
    class Game
    {
        public string[] cardName = new string[] //카드 이름 목록
            { "파이어볼", "기사", "궁수", "자이언트", "화살", "골렘", "마녀", "마법사"};
        public int[] arr = new int[] { 0, 1, 2, 3, 4, 5, 6, 7 }; // 카드 번호
        public int[] cardOrder = new int[8]; //셔플된 카드 번호 목록


        public void Process()
        {
            ShuffleCard(arr);
            ShowCard();
            
        }


        public void ShuffleCard(int[] arr) //랜덤 셔플
        {
            
            Random random = new Random();
            arr = arr.OrderBy(x => random.Next()).ToArray();   

            cardOrder = arr; //왜인지는 모르겠지만 arr변수에 기록된 셔플된 번호들이
                             //ShowCard() 매소드에서 초기화가 되어서
                             //할 수 없이 cardOrder 이라는 변수에 저장

            string[] temp = new string[8];

            for (int i = 0; i < 8; i++)
            {
                temp[i] = cardName[cardOrder[i]];
            }
            cardName = (string[])temp.Clone();
        }

        private void ShowCard() //hand 에 들어갈 카드 출력 & next card에 갈 카드 출력
        {
            Console.Write("Hand : "); 
            for (int i = 0; i < 4; i++)
            {
                Console.Write($"{cardName[i]} ");
            }
            Console.WriteLine(); 
            Console.Write("Next Card : ");
            Console.WriteLine($"{cardName[4]}" );
        }

        private void ChooseCard()
        {
            string input = Console.ReadLine();

            
        }

        private void CheckCard(string input)
        {
            
        }
        
       /* private int GetIndexOf (string[] cardName, string input)
        {
            for (int i = 0; i < cardName.Length; i++)
            {
                if (input == cardName[i])
                {
                    return i;
                }
                else
                {
                    return -1;
                }
            }
        }*/
        
    }
}
