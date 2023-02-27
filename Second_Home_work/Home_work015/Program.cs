// Задача 15: Напишите программу, которая 
//принимает на вход цифру, обозначающую день недели, 
//и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

string dayOfWeek = DayOfWeek(number);

Console.WriteLine(number < 6 && number > 0 ? $"Число {number} {dayOfWeek} день" :
$"Число {number} {dayOfWeek}" , $"Число {number} вообще не является днём недели");

string DayOfWeek(int numb)
{
    if (numb < 6 && numb > 0) return "не выходной";
    else if (numb <= 0 || numb > 7) return "Такого дня нет";
    else
    return "Выходной";
}