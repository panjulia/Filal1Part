// Напишите цикл, который принимает на вход два числа (A и B) и 
// возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
double Pow(int a, int b)
{
 double n;
     n = Math.Pow(a, b);
return n;
}
Console.Clear();
Console.WriteLine("Введите число А: ");
int A = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число В: ");
int B = int.Parse(Console.ReadLine()!);


double resalt = Pow(A, B);
Console.WriteLine($"Число А в степени В равно: {Pow(A, B)}");