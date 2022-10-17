// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и
// выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int [] GetArrayFromString(string stringArray)
{
    string[] nums = stringArray.Split(", ", StringSplitOptions.RemoveEmptyEntries);
    int[] res = new int[nums.Length];

    for (int i = 0; i < nums.Length; i++)
    {
        res[i] = int.Parse(nums[i]);
    }
    return res;
}

Console.Clear();
Console.WriteLine("Введите массив из 8 элементов через запятую и пробел: ");
string input = Console.ReadLine();
int[] array = GetArrayFromString(input);
Console.WriteLine(String.Join(", ", array));
