// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

double Dist(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double result;
    result = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1) + (z2 - z1) * (z2 - z1));

    return result;
}
Console.Clear();
Console.WriteLine("Введите координаду Х точки А:");
int ax = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координаду Y точки А:");
int ay = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координаду Z точки А:");
int az = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координаду Х точки B:");
int bx = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координаду Y точки А:");
int by = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координаду Z точки А:");
int bz = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Длина отрезка равна: {Dist(ax, ay, az, bx, by, bz):f2}");


