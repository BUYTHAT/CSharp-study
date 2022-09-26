# if와 else

if (참 또는 거짓의 조건문)
{
	*참 일시, 실행*
} else if (참 또는 거짓의 조건문)
{
	*참 일시, 실행*
} else {
	*위 조건문에 대하여 참이 아닌경우  실행*
}

# switch

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

삼항연산자

bool isPair = ( 조건 ? 맞을때 : 틀릴때 );
ex)bool isPair = ((number & 2) == 0 ? true : false);