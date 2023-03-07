// Напишите программу, которая принимает на вход 
// пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите число: ");
int fiveDigitNumber = Convert.ToInt32(Console.ReadLine());

void Palindrom(int number)
{
    if (number < 0) number = -number;
    if ((double) number / 10 > 1000)
    {
        int i = number / 10000; int j = number % 10;
        int g = (number / 1000) % 10; int l = (number % 100) / 10;
        if (i == j && g == l) Console.WriteLine($"Число {number} является палиндром");
        else Console.WriteLine($"Число {number} не является палиндром");
    }
    else Console.WriteLine("Это не пятизначное число!");
}

Palindrom(fiveDigitNumber);