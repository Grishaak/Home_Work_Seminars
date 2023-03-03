// Задача 23
// Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125


Console.Write("введите число N:");
int number = Convert.ToInt32(Console.ReadLine());

TableCube(number);

void TableCube(int n)
{
    for (int i = 1; i <= n; i++)
        Console.WriteLine($"Кубы числа {i} - {Math.Pow(i ,3)}");
}
