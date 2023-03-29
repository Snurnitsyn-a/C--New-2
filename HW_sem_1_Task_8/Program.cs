/*Задача 8: Напишите программу, которая на вход принимает 
число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8*/

int N = int.Parse(Console.ReadLine());
int a = 1;
int mod_a = a % 2;
while (a < N)
{
    a += 1;
    mod_a = a % 2;
    if (mod_a == 0)
    {
        Console.Write(a + " ");
    }
}
