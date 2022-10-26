// Задача 50. Напишите программу, которая на вход принимает число и 
// возвращает индексы элемента в двумерном массиве или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
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

void NumArray(int[,] inArray, int num)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            if (inArray[i, j] == num)
            {

                Console.Write($"Индексы числа {num} равны: {j}, и {i}\t ");
                return;

            }


        }
    }
        Console.WriteLine($"нет такого числа в массиве ");
}

Console.Clear();
Console.Write("Введите количество строк в массиве: ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов в массиве: ");
int columns = int.Parse(Console.ReadLine()!);
Console.Write("Введите число: ");
int Num = int.Parse(Console.ReadLine()!);

int[,] Array = GetArray(row, columns, 0, 10);
PrintArray(Array);
NumArray(Array, Num);
// Console.WriteLine();
// PrintArray(Array);