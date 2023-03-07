// Задача 27: Напишите программу, которая принимает
// на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int sumDigit = SumDigits(number);
Console.WriteLine($"{sumDigit}");

int SumDigits(int num)
{
    int result = 0;
    while ( num > 10)
    {
        int tempDigit = (num % 10);
        result += tempDigit;
        num = num / 10;
    }
    return result += num;
}