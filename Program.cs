using System;

namespace CSharp
{
    class Program
    {
        enum ClassType
        {
            None = 0,
            Knight = 1,
            Archer = 2,
            Mage = 3,
        }

        struct Player
        {
            public int hp;
            public int attack;
            
        }

        static ClassType ChooseClass()
        {

            Console.WriteLine("직업을 선택해주세요!");
            Console.WriteLine("[1] 기사");
            Console.WriteLine("[2] 궁수");
            Console.WriteLine("[3] 법사");

            ClassType choice = ClassType.None;

            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    choice = ClassType.Knight;
                    break;
                case "2":
                    choice = ClassType.Archer;
                    break;
                case "3":
                    choice = ClassType.Mage;
                    break;
            }
            return choice;
        }

        static void CreatePlayer(ClassType choice, out Player player)
        {
            

            switch (choice)
            {
                case ClassType.Knight:
                    player.hp = 100;
                    player.attack = 10;
                    break;
                case ClassType.Archer:
                    player.hp = 75;
                    player.attack = 12;
                    break;
                case ClassType.Mage:
                    player.hp = 50;
                    player.attack = 15;
                    break;
                default:
                    player.hp = 0;
                    player.attack = 0;
                    break;

            }
        }



        static void Main(string[] args)
        {
            

            

            while (true)
            {
                ClassType choice = ChooseClass();
                if (choice != ClassType.None)
                {

                    Player player;   //구조체 변수 선언
                   

                    CreatePlayer(choice, out player);

                    switch (choice)
                    {
                        case ClassType.Knight:
                            Console.Write("기사");
                            break;
                        case ClassType.Archer:
                            Console.Write("궁수");
                            break;
                        case ClassType.Mage:
                            Console.Write("법사");
                            break;

                    }

                    Console.Write($" HP : {player.hp} / ATTACK : {player.attack}");

                    break;
                    
                }
                    
            }

        }




    }
}
