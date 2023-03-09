// Задача 36: 
// 1. Задайте одномерный массив, заполненный случайными числами. 
// 2. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
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

int SumElementsByPositions(int[] arr)
{
    int position = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (i % 2 != 0) position += arr[i];
    }
    return position;
}

int[] array = CreateArrayRndInt(4, 1, 10);
PrintArray(array);

int sumElementPosition = SumElementsByPositions(array);
Console.WriteLine($"Сумма чисел стоящих на нечетной позиции в массиве -> {sumElementPosition}");
