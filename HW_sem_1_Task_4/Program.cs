/*Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22*/

(int a, int b, int c) = (int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
int Max = a;
if (b > a & b > c)
{
    Max = b;
}
if (c > a & c > a)
{
    Max = c;
}
Console.Write("max = " + Max);
