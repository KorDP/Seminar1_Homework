Console.Write("Введите число ");
int num = Convert.ToInt32(Console.ReadLine());

if (num % 2 == 0)
{
    Console.WriteLine($"{num} число четное");
}
else 
{
    Console.WriteLine($"{num} число нечетное");
}