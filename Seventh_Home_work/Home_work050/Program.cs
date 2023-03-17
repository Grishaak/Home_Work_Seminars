// Задача 50. Напишите программу, которая на вход
// принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, 
// что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого элемента в массиве нет

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

void PrintArray(int[,] arr)
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

bool FindmatrixElement(int[,] arr, int row, int column)
{
    return (row - 1 < arr.GetLength(0) && column - 1 < arr.GetLength(1));
}

int[,] matrix = CreateMatrixRndInt(4, 4, -10, 10);

PrintArray(matrix);

Console.WriteLine("Введите строку матрицы элемента котрого хотите найти:");
int rowNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите столбец матрицы элемента котрого хотите найти:");
int columnNumber = Convert.ToInt32(Console.ReadLine());

bool responce = FindmatrixElement(matrix, rowNumber, columnNumber);
Console.WriteLine(responce ? $"Такой элемент есть и он {matrix[rowNumber - 1, columnNumber - 1]}" : "Нет, такого элемента нет!");