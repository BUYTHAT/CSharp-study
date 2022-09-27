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


        static void Main(string[] args)
        {
            

            

            while (true)
            {
                ClassType choice = ChooseClass();
                if (choice != ClassType.None)
                    break;
            }




            //내가 한것
            /*
            int JobChoice;

            do
            {
                Console.WriteLine("직업을 선택해주세요!");
                Console.WriteLine("[1] 기사");
                Console.WriteLine("[2] 궁수");
                Console.WriteLine("[3] 법사");

                JobChoice = Convert.ToInt32(Console.ReadLine());

            } while (JobChoice != 1 && JobChoice != 2 && JobChoice != 3);
            */

        }




    }
}
