// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int GetSum(int n, int m)
{
    if (n == m)
    {
        return m;
    }
    return n + GetSum(n + 1, m);
}

Console.Clear();
Console.Write("Введите число N: ");
int n = int.Parse(Console.ReadLine()!);
Console.Write("Введите число M: ");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine(GetSum(n, m));