using System;

namespace CSharp
{
    class Program
    {
        // 여기에 주석을 달 수 있어요
        /* 여기세 주석을 달 수 있어요 */
        static void Main(string[] args)
        {
            // byte(1바이트 0~255), short(2바이트-3만~3만), int(4바이트 -21억~21억), long(8바이트)
            // sbyte(-128~127), ushort(0~6만), uint(0~43억), ulong
            int hp;
            short level = 100;
            long id;

            hp = 100;


            Console.WriteLine("Hello Number ! {0}", hp);
        }
    }
}