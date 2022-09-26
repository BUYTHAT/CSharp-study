using System;

namespace CSharp
{
    class Program
    {
        //열거
        enum Choice
        {
            Rock = 1,
            Paper = 2,
            Scissors = 0
        }

        static void Main(string[] args)
        {

            // const int 상수
            // switch 에서 변수로 쓸려면 변하지 않는값이어야 함.
            /* 
            const int ROCK = 1 ;
            const int PAPER = 2;
            const int SCISSORS = 0;
            */



            // 0: 가위  1: 바위  2: 보
            
            Random rand = new Random();
            int aiChoice = rand.Next(0, 3); // 0~2 사이의 랜덤값

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case (int)Choice.Scissors:
                    Console.WriteLine("당신의 선택은 가위입니다.");
                    break;
                case (int)Choice.Rock:
                    Console.WriteLine("당신의 선택은 바위입니다.");
                    break;
                case (int)Choice.Paper:
                    Console.WriteLine("당신의 선택은 보입니다.");
                    break;
            }

            switch (aiChoice)
            {
                case SCISSORS:
                    Console.WriteLine("컴퓨터의 선택은 가위입니다.");
                    break;
                case ROCK:
                    Console.WriteLine("컴퓨터의 선택은 바위입니다.");
                    break;
                case PAPER:
                    Console.WriteLine("컴퓨터의 선택은 보입니다.");
                    break;
            }

            // 승리 무승부 패배

            if ((choice == SCISSORS && aiChoice == PAPER) || (choice == ROCK && aiChoice == SCISSORS) || (choice == PAPER && aiChoice == ROCK))
                Console.WriteLine("승리");
            else if (choice == aiChoice)
                Console.WriteLine("무승부");
            else if ((choice == SCISSORS && aiChoice == ROCK) || (choice == ROCK && aiChoice == PAPER) || (choice == PAPER && aiChoice == SCISSORS))
                Console.WriteLine("패배");

        }
    }
}
