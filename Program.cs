using System;
using System.Net.Security;

namespace CSharp
{
    class Program
    {
        // 덧셈 함수
        static void AddOne(ref int number)
        {
            number = number + 1; 
        }

        static void Main(string[] args)
        {

            //복사 (짭) 참조 (찐)
            int a = 10;

            Program.AddOne(ref a); 

            Console.WriteLine(a);
            
        }
    }
}
