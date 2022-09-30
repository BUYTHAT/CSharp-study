using System;

namespace CSharp
{
    class Program
    {
        static void Main(string[] agrs)
        {
            int[] arr = new int[10];

            //list <- 동적 배열 [ 0, 1, 2, 3, 4 ] 
            List<int> list = new List<int>();
            for (int i = 0; i < 5; i++)
            {
                list.Add(i);
            }

            //삽입 삭제
            list.Insert(2, 999);

            bool success =  list.Remove(2);

            list.RemoveAt(0);
            list.Clear();

            for (int i = 0; i < list.Count; i++)
                Console.WriteLine(list[i]) ;

            foreach (int num in list)
                Console.WriteLine(num);

        }
    }
}