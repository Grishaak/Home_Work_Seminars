// Задача 25: Напишите цикл, который принимает на вход два числа 
// (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите число число: ");
double numberA = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите настуральное число: ");
int numberB = Convert.ToInt32(Console.ReadLine());

double Natural(double numA, int numB)
{
    double result = 0;
    while (numB < 0)
    {
        Console.WriteLine("Вы ошиблись, введите натуральную степень положительной: ");
        return numberB = Convert.ToInt32(Console.ReadLine());   
    }
    if (numA == 1) numB = 0; result = 1;
    while (numB > 0)
    {
        result *= numA;
        numB--;
    }
    return result;
}

double natural = Natural(numberA, numberB);
Console.WriteLine($"Число {numberA} вовзеденное в натуральную сетпень {numberB} -> {natural}");
