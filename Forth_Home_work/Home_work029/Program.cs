// Задача 29: Напишите программу, которая задаёт массив
// из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

int[] array = new int[8];

// void PrintArray(int[] col)
// {
//     for (int i = 0; i < col.Length; i++)
//     {
//         Console.Write($"{col[i]} ");
//     }
//     Console.WriteLine();
// }

// void FillArray(int[] arr)
// {
//     Random rnd = new Random();
//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = rnd.Next(0,101);
//     }
// }

void CreateArray(int[] arr)
{
    Random rnda = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnda.Next(0,101);
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

CreateArray(array);
// PrintArray(array);
// FillArray(array);
// PrintArray(array);