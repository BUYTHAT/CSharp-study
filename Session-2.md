# if�� else

if (�� �Ǵ� ������ ���ǹ�)
{
	*�� �Ͻ�, ����*
} else if (�� �Ǵ� ������ ���ǹ�)
{
	*�� �Ͻ�, ����*
} else {
	*�� ���ǹ��� ���Ͽ� ���� �ƴѰ��  ����*
}

# switch

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

���׿�����

bool isPair = ( ���� ? ������ : Ʋ���� );
ex)bool isPair = ((number & 2) == 0 ? true : false);