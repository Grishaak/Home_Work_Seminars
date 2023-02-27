// Задача 13: Напишите программу, которая выводит
// третью цифру заданного числа или сообщает,
// что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

int secondDigit = SecondDigit(number);
Console.WriteLine(number > 100? $"Третья цифра числа {number} -> {secondDigit}":
 $"Число {number} не является трёхзначным");

int SecondDigit(int numb)
{
   if (numb < 100) return 0;
   if (numb > 100 && numb < 1000) return numb % 10;
   if ( numb >= 1000)
   {
      while (numb >= 1000)
      {
        numb = numb / 10;
      }
   }  return numb % 10; 
}