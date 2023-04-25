// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

Console.WriteLine("введите первое число:");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите второе число:");
int number1 = Convert.ToInt32(Console.ReadLine());

int degNumbers = DegNumbers(number, number1);
Console.WriteLine(degNumbers);


int DegNumbers(int number, int number1) // int num = number
{
    int sum = 1;
    for (int i = 0; i < number1; i++)
    {
        sum *= number; 
    } 
    return sum;
}