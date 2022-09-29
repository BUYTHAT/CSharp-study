using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_study
{
    public enum MonsterType
    {
        None = 0,
        Slime = 1,
        Orc = 2,
        Skeleton = 3
    }

    class Monster : Creature
    {
        protected MonsterType type = MonsterType.None;
        public string monsterName;
        protected Monster(MonsterType type) : base(CreatureType.Monster)
        {
            this.type = type;
        }

        public MonsterType GetMonsterType() { return type; }

        public void IntroduceMonster() {
            Console.WriteLine($"{monsterName}이(가) 생성되었습니다!");
        }

     }


    class Slime : Monster
    {
        public Slime() : base(MonsterType.Slime)
        {
            monsterName = "슬라임";
            SetInfo(10, 10, 10);
        }
    }
    class Orc : Monster
    {
        public Orc() : base(MonsterType.Orc)
        {
            monsterName = "오크";
            SetInfo(20, 15, 20);
        }
    }
    class Skeleton : Monster
    {
        public Skeleton() : base(MonsterType.Skeleton)
        {
            monsterName = "스켈레톤";
            SetInfo(15, 25, 15);
        }
    }

}
