# if�� else

```
if (�� �Ǵ� ������ ���ǹ�)
{
	*�� �Ͻ�, ����*
} else if (�� �Ǵ� ������ ���ǹ�)
{
	*�� �Ͻ�, ����*
} else {
	*�� ���ǹ��� ���Ͽ� ���� �ƴѰ��  ����*
}
```

# switch

```
switch (choice)
{
    case 0:
        Console.WriteLine("�����Դϴ�.");
        break;
    case 1:
        Console.WriteLine("�����Դϴ�.");
        break;
    case 2:
        Console.WriteLine("���Դϴ�.");
        break;
    case 3:
        Console.WriteLine("ġƮŰ�Դϴ�.");
        break;
    default:
        Console.WriteLine("�� ���� �߽��ϴ�.");
        break;
}
```

##���׿�����

bool isPair = ( ���� ? ������ : Ʋ���� );
ex)bool isPair = ((number & 2) == 0 ? true : false);

# ����� ������

const int  =  ���
switch ���� ������ ������ ������ �ʴ� ����� �̾�� ��.

```
const int SCISSORS = 0;
const int ROCK = 1;
const int PAPAER = 2;
```

##������

```
enum Choice
{
    Rock = 1,
    Paper = 2,
    Scissors = 0
}
```

����Ÿ���� �ƴ� enum ���̱� ������
int�� ��ȯ

```
(int)Choice.Scissors
```

# while

������ ������Ű�� �� ��ɹ� �ݺ�����

```
while ( ���� )
{
    ���
}
```

##do while ��

do �ȿ��ִ� ��� ���� ����,
while ���ǿ� ���� �ݺ�����

```
do
{

} while () ;
```


#for

```
for (�ʱ�ȭ��; ���ǽ�; �ݺ���)
{

}
```



