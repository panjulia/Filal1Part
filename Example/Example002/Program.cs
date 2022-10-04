// Задача 2: Напишите программу, которая на вход принимает два числа и 
// выдаёт, какое число большее, а какое меньшее.
Console.Clear();
Console.WriteLine("Введите первое число:");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число:");
int b = int.Parse(Console.ReadLine()!);
int max = a;
int min = b;
if (b > a)
{
    Console.WriteLine("b = max");
    Console.WriteLine("a = min");
}
else
{
    Console.WriteLine($" {a} = max");
    Console.WriteLine($"{b} = min");
}
