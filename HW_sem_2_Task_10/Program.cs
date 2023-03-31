/*Задача 10: Напишите программу, которая принимает на вход 
трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1*/

Console.WriteLine("Enter a 3 digit number ");
int N = int.Parse(Console.ReadLine());
int mod_100 = N % 100;
int result = mod_100 / 10;
if (N < 100 | N > 999)
{
    Console.WriteLine("The number has either more or less than 3 digits");    
}
else
{
    Console.WriteLine("The 2nd digit is " + result);
}
