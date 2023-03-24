// Задача 66: Задайте значения M и N.
// Напишите программу, которая найдёт
// сумму натуральных элементов в промежутке от M до N.
// Выполнить с помощью рекурсии.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите натуральное M:");
int numberOne = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральное N:");
int numberTwo = Convert.ToInt32(Console.ReadLine());

int naturalSum = NaturalSum(numberOne, numberTwo);
System.Console.WriteLine($"{naturalSum}");

int NaturalSum(int numOne, int numTwo)
{
    if (numOne <=  numTwo) return numOne + NaturalSum(numOne + 1, numTwo);
    else return 0;
}