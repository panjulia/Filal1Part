// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию 
// элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] inArray = new int[m, n];

    for (int i = 0; i < m; i++)
        for (int j = 0; j < n; j++)
        {
            inArray[i, j] = new Random().Next(minValue, maxValue + 1);
        }

    return inArray;
}
void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]}\t ");
        }
        Console.WriteLine();
    }
}
int[,] SortArray(int[,] arrsort)
{
    int temp = 0;
    for (int i = 0; i < arrsort.GetLength(0); i++)
    {
        for (int j = 0; j < arrsort.GetLength(1); j++)
        {
            for (int k = 0; k < arrsort.GetLength(1) - 1; k++)
            {
                if (arrsort[i, k] < arrsort[i, k + 1])
                {
                    temp = arrsort[i, k];
                    arrsort[i, k] = arrsort[i, k + 1];
                    arrsort[i, k + 1] = temp;
                }
            }
        }
    }
    return arrsort;
}

Console.Clear();
Console.Write("Введите количество строк в массиве: ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов в массиве: ");
int columns = int.Parse(Console.ReadLine()!);

int[,] Array = GetArray(row, columns, 0, 10);
Console.WriteLine("Начальный массив:");
PrintArray(Array);
Console.WriteLine("Отсортированный массив:");
PrintArray(SortArray(Array));
