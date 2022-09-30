using System;

namespace CSharp
{
    class Program
    {
        static void Main(string[] agrs)
        {
            int[,] map = new int[2, 3];


            // [  ,   ,   ,   ]
            // [  ,   ,   ,   ,   ,   ,   ]
            // [  ,   ,   ,   ,   ]

            int[][] a = new int[3][];
            a[0] = new int[3];
            a[1] = new int[5];
            a[2] = new int[2];

            a[0][0] = 1;

             
        }
    }
}