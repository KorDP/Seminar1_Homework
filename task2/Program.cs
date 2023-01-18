Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите первое число: ");
int b = Convert.ToInt32(Console.ReadLine());

if (a > b)
{
    Console.WriteLine($"Большее число: {a}");
}
else if (a < b)
{
    Console.WriteLine($"Большее число: {b}");
} else 
{
    Console.WriteLine("Числа одинаковы");
}