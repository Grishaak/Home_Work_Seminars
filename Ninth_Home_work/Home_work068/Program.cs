// Задача 68: Напишите программу вычисления функции
// Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine("Введите m:");
int numberOne = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите n:");
int numberTwo = Convert.ToInt32(Console.ReadLine());

int acr = AchermanFunction(numberOne, numberTwo);
Console.WriteLine($"m = {numberOne}, n = {numberTwo} -> A(m,n) = {acr}");

int AchermanFunction(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0)
    {
        return AchermanFunction(m - 1, 1);
    }
    else
    {
        return AchermanFunction(m - 1, AchermanFunction(m, n - 1));
    }
}