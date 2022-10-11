// Напишите программу, которая принимает на вход пятизначное число
//  и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
Console.Clear();
Console.WriteLine("Введите пятизначное число:");
int Num = int.Parse(Console.ReadLine()!);
void Numer(int num)
{
int a1 = num % 100;
int a2 = num / 1000;
if ((a1 / 10 == a2 % 10) && (a1 % 10 == a2 / 10))

{
    Console.WriteLine($"Число {Num} - палиндром");
}
else
{
    Console.WriteLine($"Число {Num} - не палиндром");
}
}
Numer(Num);