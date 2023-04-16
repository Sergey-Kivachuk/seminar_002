// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

int Prompt(string messge)
{
    Console.WriteLine(message);
    int result = Convert.ToInt32(value);
    return result;
}
 int IsSquare(int number) 
 {
   while (number > 999);
   {
      number /=10;
   }
      return number % 10;
 }      

bool  MaxDigit (int number) 
{
    if (number>100)
    {
        Console.WriteLine("Третьей цифры нету");
        return false;
    }
    return true;
}
int number = Prompt("число ");
if (MaxDigit (number))
{
    Console.WriteLine( IsSquare (number));
}