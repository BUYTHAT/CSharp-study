using System;

namespace CSharp
{
    class Monster
    {
        public int id;
        public Monster(int id)
        {
            this.id = id;
        }
        
    }

    class Program
    {
        static void Main(string[] agrs)
        {
            List<int> list = new List<int>();


            Dictionary<int, Monster> dic = new Dictionary<int, Monster>();

            dic.Add(1, new Monster(1));
            dic[5] = new Monster(5);

            for (int i = 0; i < 10000; i++)
                dic.Add(i, new Monster(i));

            Monster mon = dic[7777];
        }
    }
}