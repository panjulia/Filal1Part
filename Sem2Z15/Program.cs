// Задача 15: Напишите программу, которая принимает на вход цифру, 
//обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет
Console.Clear();
Console.WriteLine("Введите число дня недели:");
int num = int.Parse(Console.ReadLine()!);
if ((num >= 1) && (num <= 5))
{
    Console.WriteLine("Будний день");
}

else if ((num == 6) || (num == 7))
{
    Console.WriteLine("Выходной день");
}


else
{
    Console.WriteLine("Нет такого дня");
}
