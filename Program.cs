using System;

namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {

            /*int num = 98; //1, 97로만 나뉘는 숫자

            bool isPrime = true;
            for (int i = 2; i < num; i++)
            {
                if ((num % i) == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            if (isPrime)
            {
                Console.WriteLine("소수입니다!");
            } else {
                Console.WriteLine("소수가 아닙니다!");
            }*/

            for (int i = 1; i <= 100; i++)
            {
                if ((i % 3) == 0)
                {
                    Console.WriteLine("3의 배수 발견! : {0}", i);
                }
            }



            for (int i = 1; i <= 100; i++)
            {
                if ((i % 3) != 0)
                {
                    continue;
                }
                Console.WriteLine("3의 배수 발견! : {0}", i);
            }


        }
    }
}
