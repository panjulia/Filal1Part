// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// k1 * x + b1 = k2 * x + b2
// (k1 - k2) * x = b2 - b1

// x = (b2 - b1) / (k1 - k2)
// y = k1 * x + b1 
void coord(double b1, double k1, double b2, double k2)
{
    if (k1 == k2)
    {
        Console.WriteLine($"Прямые паралельны");
    }
    else
    {
        double x = (b2 - b1) / (k1 - k2);
        double y = k2 * x + b2;
        Console.WriteLine($"Перечесение в точке: {x};{y}");
    }
}
Console.Clear();
Console.WriteLine("Введите b1: ");
double b1 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите k1: ");
double k1 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите b1: ");
double b2 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите k2: ");
double k2 = double.Parse(Console.ReadLine()!);
coord(b1, k1, b2, k2);