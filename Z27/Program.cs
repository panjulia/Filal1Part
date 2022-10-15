//Задача 27: Напишите программу, которая принимает на вход число и 
// выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
int Sum(int n)
{
    int sum = 0;
    while (n > 0)
    {
        sum = sum + (n % 10);
        n = n / 10;
    }
    return sum;
}
Console.Clear();
Console.WriteLine("Введите число N: ");
int N = int.Parse(Console.ReadLine()!);


Console.WriteLine($"сумма цифр в числе {N} равнa: {Sum(N)}");