// Задача 54: Задайте двумерный массив. 
// Напишите программу, которая упорядочит 
// по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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

// 8  3  0 15
// 9 11  8  0
// 6  9 20  3

void SortMatrix(int[,] matrix)
{
    int rowSize = matrix.GetLength(0);
    int columnSize = matrix.GetLength(1);
    int row = 0;
    int column = 0;
    for (int i = 0; i < rowSize; i++)
    {
        for (int j = 0; j < columnSize; j++)
        {
            int max = matrix[i, j];
            for (int k = j; k < columnSize; k++)
            {
                if (max <= matrix[i, k])
                {
                    row = i;
                    column = k;
                    max = matrix[row, column];
                }
                if (k == columnSize - 1)
                {
                    int temp = matrix[i, j];
                    matrix[i, j] = matrix[row, column];
                    matrix[row,column] = temp;
                }
            }
        }
    }
}




int[,] matrix = CreateMatrixRndInt(3, 5, -1000, 1001);
PrintMatrix(matrix);
System.Console.WriteLine();
SortMatrix(matrix);
PrintMatrix(matrix);


