# TextRPG

TextRPG 프로젝트를 하면서 몰랐던, 또는 기억했으면 좋을 문법들을 정리


Consol.Write 에서 string 속에 int 변수를 넣고싶을때
""앞에 $를 두고 {변수이름} 으로 값 호출 가능

```
Console.Write($"HP : {hp} / ATTACK : {attack}");
```

### ClassType

`int choice;` 를 하면 'int' 타입의 변수를 할당해서 ''choice'라는 이름으로 코드에서 활용하는데,
마찬가지로 `ClassType choice;`를 하면 'ClassType' 타입의 변수를 할당하게됨

```
enum ClassType
{
	None = 0,
	Knight = 1,
	Archer = 2,
	Mage = 3
}
```

ClassType은 enum 타입이기 때문에 위 4개의 값 중 하나를 골라서 사용함
메모리 상으로는 일반 정수처럼 1, 2, 3 혹은 4에 불과하지만,
C# 코드에선 1, 2, 3 이라는 의미없는 값을 하드코딩해서 넣는 것이 아니라
ClassType.Knight와 같이 우리가 알아보기 쉬운 값을 사용할 수 있게 됨


### 구조체, struct

```
struct Player  // 구조체 정의
        {
            public int hp;         //구조체 멤버 구성
            public int attack;
            public int level;
            public char name;
        }

Player p1; //구조체 p1변수 선언

p1.hp = 100;       //p1.으로 구조체 멤버에 접근하여 값 할당
p1.level = 300;
```

#### Console.ReadLine

Console.ReadLine을 통해 읽게되면 무조건 string 형식
