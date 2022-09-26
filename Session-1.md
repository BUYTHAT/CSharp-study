#정수형식

데이터 + 로직 

byte(1바이트 0~255), short(2바이트-3만~3만), int(4바이트 -21억~21억), long(8바이트)
sbyte(-128~127), ushort(0~6만), uint(0~43억), ulong()

#2진수, 10진수, 16진수

10진수
00 01 02 03 04 05 06 07 08 09 
10
            
2진수
0~1
0b00 0b01 0b10 0b11 0b100
0b10001111 = 0x8F

16진수
0~9 a b c d e f
0x00 0x01 0x02 0x03 . . 0x0f
0x10

#불리언, 소수, 문자, 문자열 형식

1바이트 ( 참/거짓 )
bool b;            
b = true;
b = false;

소수
4바이트
float f = 3.14f;

8바이트 
double d = 3.14;

2바이트
char c = '글';
string str = "Hello World";

#데이터 연산

++ / -- 의 순서
hp++;
hp--;

++hp;
--hp;

< <= >= > == !=
bool b = hp == 100;
hp 값이 100과 일치?

bool b = hp != 100;
hp 값이 100과 다른가?

&& AND
|| OR
! NOT


