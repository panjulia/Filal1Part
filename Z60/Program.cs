// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)
int[,,] NewArray(int row, int col, int gl, int minValue, int maxValue)
{
    int[,,] arraynew = new int[row, col, gl];
    for (int i = 0; i < arraynew.GetLength(0); i++)
    {
        for (int j = 0; j < arraynew.GetLength(1); j++)
            for (int k = 0; k < arraynew.GetLength(2); k++)
            {
                arraynew[i, j, k] = new Random().Next(minValue, maxValue);
            }
    }
    return arraynew;
}

int[] New1DArray(int row, int col, int gl)
{
    int[] inArray = new int[row * col * gl];
    
    for (int i = 0; i < inArray.GetLength(0); i++)
        
        {
            int num = new Random().Next(10, 100);
            if (inArray[i] == num)               
            {
                i--;
            }
            else
            {
                inArray[i] = num;
            }
        }
    return inArray;
}

void Print3DArray(int[,,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            for (int k = 0; k < inArray.GetLength(2); k++)
            {
                Console.Write($"{inArray[i, j, k]} ({i},{j},{k}) \t");
            }
            Console.WriteLine();
        }

    }

}

Console.Clear();
Console.Write("Введите количество строк в массиве");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов в массиве ");
int col = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество страниц в массиве ");
int gl = int.Parse(Console.ReadLine()!);
int[,,] ArrayA = NewArray(row, col, gl, 10, 100);
int[] array1d = New1DArray(row, col, gl);
Print3DArray(ArrayA);