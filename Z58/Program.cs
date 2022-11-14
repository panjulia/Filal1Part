// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] NewArray(int row, int col, int minValue, int maxValue)
{
    int[,] arraynew = new int[row, col];
    for (int i = 0; i < arraynew.GetLength(0); i++)
    {
        for (int j = 0; j < arraynew.GetLength(1); j++)
        {
            arraynew[i, j] = new Random().Next(minValue, maxValue);
        }
    }
    return arraynew;
}

void PrintArray(int[,] arrprint)
{
    for (int i = 0; i < arrprint.GetLength(0); i++)
    {
        for (int j = 0; j < arrprint.GetLength(1); j++)
        {
            Console.Write($"{arrprint[i, j]}\t ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] MultiArrays(int[,] arrA, int[,] arrB)
{
    if (arrA.GetLength(1) != arrB.GetLength(0))
    {
        // return arrA;
        Console.WriteLine("Матрицы нельзя перемножить");
    }
    int[,] r = new int[arrA.GetLength(0), arrB.GetLength(1)];
    for (int i = 0; i < arrA.GetLength(0); i++)
    {
        for (int j = 0; j < arrB.GetLength(1); j++)
        {
            for (int k = 0; k < arrB.GetLength(0); k++)
            {
                r[i, j] += arrA[i, k] * arrB[k, j];
            }
        }
    }
    return r;
}
Console.Clear();
Console.Write("Введите количество строк в матрице 1: ");
int row1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов в матрице 1: ");
int columns1 = int.Parse(Console.ReadLine()!);
int[,] ArrayA = NewArray(row1, columns1, 0, 10);

Console.Write("Введите количество строк в матрице 2: ");
int row2 = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов в матрице 2: ");
int columns2 = int.Parse(Console.ReadLine()!);
int[,] ArrayB = NewArray(row2, columns2, 0, 10);

int[,] ArrayC = MultiArrays(ArrayA, ArrayB);


Console.WriteLine("Матрица 1:");
PrintArray(ArrayA);
Console.WriteLine("Матрица 2:");
PrintArray(ArrayB);
Console.WriteLine("Произведение двух матриц: ");
PrintArray(ArrayC);

