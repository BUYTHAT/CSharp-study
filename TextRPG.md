# TextRPG

TextRPG ������Ʈ�� �ϸ鼭 ������, �Ǵ� ��������� ���� �������� ����


Consol.Write ���� string �ӿ� int ������ �ְ������
""�տ� $�� �ΰ� {�����̸�} ���� �� ȣ�� ����

```
Console.Write($"HP : {hp} / ATTACK : {attack}");
```

####ClassType

`int choice;` �� �ϸ� 'int' Ÿ���� ������ �Ҵ��ؼ� ''choice'��� �̸����� �ڵ忡�� Ȱ���ϴµ�,
���������� `ClassType choice;`�� �ϸ� 'ClassType' Ÿ���� ������ �Ҵ��ϰԵ�

```
enum ClassType
{
	None = 0,
	Knight = 1,
	Archer = 2,
	Mage = 3
}
```

ClassType�� enum Ÿ���̱� ������ �� 4���� �� �� �ϳ��� ��� �����
�޸� �����δ� �Ϲ� ����ó�� 1, 2, 3 Ȥ�� 4�� �Ұ�������,
C# �ڵ忡�� 1, 2, 3 �̶�� �ǹ̾��� ���� �ϵ��ڵ��ؼ� �ִ� ���� �ƴ϶�
ClassType.Knight�� ���� �츮�� �˾ƺ��� ���� ���� ����� �� �ְ� ��


#### ����ü, struct

```
struct Player  // ����ü ����
        {
            public int hp;         //����ü ��� ����
            public int attack;
            public int level;
            public char name;
        }

Player p1; //����ü p1���� ����

p1.hp = 100;       //p1.���� ����ü ����� �����Ͽ� �� �Ҵ�
p1.level = 300;
```


