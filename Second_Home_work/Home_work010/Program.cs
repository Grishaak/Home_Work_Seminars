// Задача 10: Напишите программу, которая принимает
// на вход трёхзначное число и на выходе 
// показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

int secondDigit = FindSecondDigit(number);
Console.WriteLine($"Второе число {secondDigit} трёхзначного числа {number}");

int FindSecondDigit(int numb)
{
    return  (numb / 10) % 10;
}
