// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12


Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());

int length = Length(number);
Console.WriteLine($"Сумма чисел {number} = {length}");

int Length(int num)
{
    int count = 0;
    while (num > 0)
    {
          count += num % 10;
          num = num / 10;
    }   
    return count;
}