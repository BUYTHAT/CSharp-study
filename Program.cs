using System;

namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. 바구니 크기가 다른경우!
            int a = 0xFFFFFFF;
            short b = (short)a;

            // 2. 바구니 크기는 같긴 한데 , 부호가 다를 경우
            byte c = 255;
            sbyte sb = (sbyte)c;
            //underflow (언더플로우) overflow(오버플로우)
            //0xFF = 0b11111111 = -1

            // 3. 소수
            float f = 3.1414f;
            double d = f;


            // byte(1바이트 0~255), short(2바이트-3만~3만), int(4바이트 -21억~21억), long(8바이트)
            // sbyte(-128~127), ushort(0~6만), uint(0~43억), ulong

           

            //Console.WriteLine("Hello Number ! {0}", hp);
        }
    }
}