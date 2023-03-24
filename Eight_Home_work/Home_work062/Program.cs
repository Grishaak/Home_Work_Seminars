// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] CreateSpiralMatrix(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    int n = 1;
    int rowSize = matrix.GetLength(0);
    int columnSize = matrix.GetLength(1);
    for (int i = 0; i < rowSize; i++)
    {
        for (int j = 0; j < columnSize; j++, n++)
        {
            matrix[i, j] = n;
            if (j == (columnSize - 1))
            {
                for (i = 0; i < rowSize; i++, n++)
                {
                    matrix[i, j] = n;
                    if (i == (rowSize - 1))
                    {
                        for (j = 3; j > -1; j--, n++)
                        {
                            matrix[i, j] = n;
                            if (j == 0)
                            {
                                for (i = 3; i > 0; i--, n++)
                                {
                                    matrix[i, j] = n;
                                    if (i == 1)
                                    {
                                        for (j = 0; j < columnSize - 1; j++, n++)
                                        {
                                            matrix[i, j] = n;
                                            if (j == 2)
                                            {
                                                for ( i = 1; i < rowSize - 1; i++, n++)
                                                {
                                                    matrix[i,j] = n;
                                                    if ( i == 2)
                                                    {
                                                        for (j = 2; j > 0; j--, n ++)
                                                        {
                                                            matrix[i,j] = n;
                                                        }
                                                        return matrix; 
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
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

int[,] spiralMatrix = CreateSpiralMatrix(4, 4);
PrintMatrix(spiralMatrix);