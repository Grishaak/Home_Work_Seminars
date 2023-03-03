// Напишите программу, которая принимает на вход 
// пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите число: ");
string fiveDigitNumber = Console.ReadLine();

void Palindrom(string number)
{
    if (number.Length == 5)
    {
        int i = number[0]; int j = number[number.Length - 1];
        int g = number[1]; int l = number[number.Length - 2];
        if (i == j && g == l) Console.WriteLine($"Число {number} является палиндром");
        else Console.WriteLine($"Число {number} не является палиндром");
    }
    else Console.WriteLine("Это не пятизначное число!");
}

Palindrom(fiveDigitNumber);
