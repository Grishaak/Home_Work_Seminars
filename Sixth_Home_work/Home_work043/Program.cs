// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Введите числа: ");
Console.Write("Введите коэфициент k1: ");
double numberK1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите коэфициент k2: ");
double numberK2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите число b1: ");
double numberB1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите число b2: ");
double numberB2 = Convert.ToDouble(Console.ReadLine());

void ParalCheck()
{
    while (numberK1 == numberK2)
    {
        Console.WriteLine("Ваши коэфициенты совпадают: ");
        Console.WriteLine("Введите коэфициент k1 заново: ");
        numberK1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите коэфициент k2 заново: ");
        numberK2 = Convert.ToInt32(Console.ReadLine());
    }
}

double XCoordinateFind(double k1, double k2, double b1, double b2)
{
    double x = (b2 - b1) / (k1 - k2);
    return x;
}

double YCoordinateFind(double k1, double b1, double x)
{
    double y = k1 * x + b1;
    return y;
}


ParalCheck();
double xCoordinate = XCoordinateFind(numberK1, numberK2, numberB1, numberB2);
double yCoordinate = YCoordinateFind(numberK1, numberB1, xCoordinate);
Console.WriteLine($" Точкой пересечения двух прямых являются координаты ({Math.Round(xCoordinate, 2)} ; {Math.Round(yCoordinate, 2)})");