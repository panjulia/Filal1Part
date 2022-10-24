// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0
// ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
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
int NZero(int[] array)
{
    int result = 0;

        foreach (int el in array)
    {
        result += el > 0 ? 1 : 0;
    }
    return result;
}
Console.Clear();
Console.WriteLine("Введите массив чисел через запятую и пробел: ");
string input = Console.ReadLine()!;
int[] array = GetArrayFromString(input);
Console.WriteLine($"Кол-во чисел больше 0: {NZero(array)} ");