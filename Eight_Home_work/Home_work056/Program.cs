// Задача 56: Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в 
// каждой строке и выдаёт номер строки с
// наименьшей суммой элементов: 1 строка

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j],4} ");
        }
        Console.WriteLine();
    }
}

int FindMinSum(int[,] matrix)
{
    int result = 0;
    int min = result;
    int minIndex = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            result += matrix[i, j];
            if (i == 0) min = result;
            if (min > result && j == matrix.GetLength(1) -1 )
            {
                minIndex = i;
                min = result;
            }
        }
        result = 0;
    }
    return minIndex;
}

int[,] matrix = CreateMatrixRndInt(7, 3, 0, 5);
PrintMatrix(matrix);

int minRow = FindMinSum(matrix);
System.Console.WriteLine($"Минимальная сумма элементов в матрице находится на строке -> {minRow}");