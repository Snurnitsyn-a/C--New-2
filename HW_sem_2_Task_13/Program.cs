/*Задача 13: Напишите программу, которая выводит
 третью цифру заданного числа или сообщает,
  что третьей цифры нет.

645 -> 5
78 -> третьей цифры нет
32679 -> 6*/


int N = int.Parse(Console.ReadLine());
int x = 1;
int N1 = N / x;
while (N1 > 999)
{
    x *= 10;
    N1 = N / x;
}
int N2 = N /x;
int result = N2 % 10;
if (N2 < 100)
{
    Console.WriteLine("There is no third digit");    
}
else
{
    Console.WriteLine(result);
}