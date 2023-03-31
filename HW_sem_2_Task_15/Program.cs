/*Задача 15: Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот день выходным.

6 ->  да
7 ->  да
1 ->  нет*/

int x = int.Parse(Console.ReadLine());

if (x >= 1 && x <= 5)
{
    Console.WriteLine("No");
}
else if (x == 6 | x == 7)
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("There is no such day");
}