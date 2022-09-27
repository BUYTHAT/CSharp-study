using System;
using System.Dynamic;

namespace CSharp
{
    class Program
    {
        static int Factorial(int n)
        {
            int result = 1;

            for (int i = n; i > 0; i--)
            {
                result *= i;
            }
            return result;
        }

        static void Main(string[] args)
        {
            /*
            //구구단
            int a;
            int result;

            for (a = 2; a < 10; a++)
            {
                for (int i = 1; i < 10; i++)
                {

                    result = a * i;
                    Console.WriteLine($"{a} * {i} = {result}");
                } 
            }
            
            //별 피라미드
            int StarNum = 1;

            for (int i = 2; i < 7; i++)
            {
                while (StarNum > 0)
                {
                    Console.Write("*");
                    StarNum--;
                }
                Console.WriteLine();
                StarNum = StarNum + i; 
;
            }*/
            

            //팩토리얼구현
            // 5! = 5 * 4 * 3 * 2 * 1

            int ret = Factorial(5);
            Console.WriteLine(ret);

            




        }
    }
}
