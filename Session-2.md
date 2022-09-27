# if와 else

```
if (참 또는 거짓의 조건문)
{
	*참 일시, 실행*
} else if (참 또는 거짓의 조건문)
{
	*참 일시, 실행*
} else {
	*위 조건문에 대하여 참이 아닌경우  실행*
}
```

# switch

```
switch (choice)
{
    case 0:
        Console.WriteLine("가위입니다.");
        break;
    case 1:
        Console.WriteLine("바위입니다.");
        break;
    case 2:
        Console.WriteLine("보입니다.");
        break;
    case 3:
        Console.WriteLine("치트키입니다.");
        break;
    default:
        Console.WriteLine("다 실패 했습니다.");
        break;
}
```

##삼항연산자

bool isPair = ( 조건 ? 맞을때 : 틀릴때 );
ex)bool isPair = ((number & 2) == 0 ? true : false);

# 상수와 열거형

const int  =  상수
switch 에서 변수로 쓰려면 변하지 않는 상수값 이어야 함.

```
const int SCISSORS = 0;
const int ROCK = 1;
const int PAPAER = 2;
```

##열거형

```
enum Choice
{
    Rock = 1,
    Paper = 2,
    Scissors = 0
}
```

정수타입이 아닌 enum 값이기 때문에
int로 변환

```
(int)Choice.Scissors
```

# while

조건을 만족시키는 한 명령문 반복실행

```
while ( 조건 )
{
    명령
}
```

##do while 문

do 안에있는 명령 먼저 실행,
while 조건에 의해 반복실행

```
do
{

} while () ;
```


#for

```
for (초기화식; 조건식; 반복식)
{

}
```



