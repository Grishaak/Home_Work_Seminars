// Задача 38:
// 1. Задайте массив вещественных чисел.
// 2. Найдите разницу между максимальным и минимальным элементов массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] CreateArrayRndInt(int size)
{
    double[] arr = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        arr[i] = Math.Round(rnd.NextDouble() * rnd.Next(10, 20), 2);
    }
    return arr;
}

void PrintArray(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");
}

double FindMax(double[] arr)
{
    double max = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max) max = arr[i];
    }
    return max;
}
double FindMin(double[] arr)
{
    double min = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < min) min = arr[i];
    }
    return min;
}

double DifferenceOfElements(double max, double min)
{
    double difference = max - min;
    return difference;
}

double[] array = CreateArrayRndInt(5);
PrintArray(array);
double sumMax = FindMax(array);
double sumMin = FindMin(array);
double diffElements = DifferenceOfElements(sumMax, sumMin);

Console.WriteLine($"Разница между максимальным и минимальным элементом массива -> {Math.Round(diffElements, 2)} ");

