// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1


Console.WriteLine("Введите трехзначное число ");
int number = Convert.ToInt32(Console.ReadLine());
if (number<0)
number = -number;
int maxDigit = MaxDigit(number);
string res = ((number > 100 && number < 999) ? $"готовое число  -> {maxDigit}" : "Вы ввели не трехзначное число");
Console.Write(res);
int MaxDigit (int num) 
{
    return num / 10 % 10 ;
 }
  