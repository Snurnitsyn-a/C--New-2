Random Num = new Random();
int Formed = Num.Next(100, 1000);

int first = Formed / 100;
int last = Formed % 10;

string result = $"{first}{last}";
Console.WriteLine(Formed);
Console.WriteLine(result);

/*
int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());

if (num1 % num2 == 0)
{
    Console.WriteLine("num1 is multiple to num2");
}
else
{
   Console.WriteLine($"Not multiple {num1 % num2}"); 
} 
*/