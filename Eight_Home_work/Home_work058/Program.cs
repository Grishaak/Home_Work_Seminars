// Задача 58: Задайте две матрицы. 
// Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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

int[,] MultiplyMatrix(int[,] oneMatrix, int[,] twoMatrix)
{
    int[,] matrix = new int[oneMatrix.GetLength(0), twoMatrix.GetLength(1)];
    int l = 0;
    int k = 0;
    int result = 0;
    int count = 0;
    int i = 0;
    int j = 0;
    // if (oneMatrix.GetLength(0) == twoMatrix.GetLength(1))
    //     while (count < matrix.GetLength(0))
    //     {
    //         {
    //             for (l = 0; l < oneMatrix.GetLength(0); l++)
    //             {
    //                 for (k = 0; k < twoMatrix.GetLength(0); k++)
    //                 {
    //                     result += (oneMatrix[i, k] * twoMatrix[k, l]);
    //                 }
    //                 matrix[i, j] = result;
    //                 j++;
    //                 result = 0;
    //             }
    //             j = 0;
    //             i++;
    //             count++;
    //         }
    //     }
    // if (oneMatrix.GetLength(0) != twoMatrix.GetLength(1))
        while (count < matrix.GetLength(0))
        {
            {
                for (l = 0; l < twoMatrix.GetLength(1); l++)
                {
                    for (k = 0; k < twoMatrix.GetLength(0); k++)
                    {
                        result += (oneMatrix[i, k] * twoMatrix[k, l]);
                    }
                    matrix[i, j] = result;
                    j++;
                    result = 0;
                }
                j = 0;
                i++;
                count++;
            }
        }
    return matrix;
}


int[,] firstMatrix = CreateMatrixRndInt(3, 3, 1, 10);
PrintMatrix(firstMatrix);
System.Console.WriteLine();
int[,] secondMatrix = CreateMatrixRndInt(3, 7, 1, 10);
PrintMatrix(secondMatrix);

int[,] multyMatrix = MultiplyMatrix(firstMatrix, secondMatrix);
System.Console.WriteLine();
PrintMatrix(multyMatrix);



