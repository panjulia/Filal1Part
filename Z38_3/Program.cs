// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] DiffArray(int size, int minval, int maxval)
{
    double[] array = new double[size];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(minval, maxval);
    }
    return array;
}

double Max(double[] array)
{
    double max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
    }
    return max;
}

double Min(double[] array)
{
    double min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
        }
    }
    return min;
}

Console.WriteLine("Введите длину массива: ");
int n = int.Parse(Console.ReadLine()!);

double[] arr = DiffArray(n, 1, 100);
Console.WriteLine(String.Join(", ", arr));

double min = Min(arr);
double max = Max(arr);

Console.WriteLine($"Разница между максимальным и минимальным значением массива: {max - min}");
