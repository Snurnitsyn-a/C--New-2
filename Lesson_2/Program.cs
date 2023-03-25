/* Задача No3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
3 -> Среда
5 -> Пятница */

int num = int.Parse(Console.ReadLine());
if (num == 3)
{
    Console.WriteLine("Wednesday");
}
if (num == 5)
{
    Console.WriteLine("Friday");
}
