# ��ü����

### struct vs class

struct�� ���� ����
class�� ���� ����


```
class Knight
{
	public int hp;
	public int attack;

	public Knight Clone()
	{
		Knight knight2 = new Knight();
		knight2.hp = hp;
		knight2.attack = attack;
		return knight2;
	}
}

Knight knight1 = new Knight();
knight1.hp = 100;
knight1.attack = 10;

Knight knight2 = knight.Clone();
Knight2.hp = 0;
Knight2.attack = 100;
```

���� �ڵ忡 ������,
Knight1 hp : 100  att : 10
Knight2 hp : 0    att : 100
