// Задача 41: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int[] InputCreateArray(int mNum)
{
    int[] arr = new int[mNum];
    for (int i = 0; i < mNum; i++)
    {
        Console.Write("Введите число в массив: ");
        arr[i] = Convert.ToInt32(Console.ReadLine( ));
    }
    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");
}

int CountNumbersAverageZero(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) count++;
    }
    return count;
}



Console.Write("Введите размер массива: ");
int mNumber = Convert.ToInt32(Console.ReadLine());

int[] array = InputCreateArray(mNumber);
Console.WriteLine();
PrintArray(array);
Console.WriteLine();
int countNumbers = CountNumbersAverageZero(array);
Console.WriteLine($"В массиве c размером {mNumber} чисел больше нуля --> {countNumbers}");
