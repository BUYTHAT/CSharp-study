using System;

namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {

            /*int choice = 1; // 0:가위 1:바위 2:보 3:치트키

            switch (choice)
            {
                case 0:
                    Console.WriteLine("가위입니다.");
                    break;
                case 1:
                    Console.WriteLine("바위입니다.");
                    break;
                case 2:
                    Console.WriteLine("보입니다.");
                    break;
                case 3:
                    Console.WriteLine("치트키입니다.");
                    break;
                default:
                    Console.WriteLine("다 실패 했습니다.");
                    break;
            }*/


            // 삼항연산자

            int number = 25;

            //bool isPair = (조건 ? 맞을때 : 틀릴때);
            bool isPair = ((number & 2) == 0 ? true : false);

            if( (number & 2) == 0 )
                isPair = true;
            else
                isPair = false;

            


        }
    }
}
