// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите первое целое положительное число");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе целое положительное число");
int numberN = Convert.ToInt32(Console.ReadLine());

int temp = numberM;
if (numberM > numberN)
{
    numberM = numberN;
    numberN = temp;
}

PrintSumm(numberM, numberN, temp = 0);

void PrintSumm(int numberM, int numberN, int sum)
{
    sum = sum + numberN;
    if (numberN <= numberM)
    {
        Console.Write($"Сумма элементов = {sum} ");
        return;
    }
    PrintSumm(numberM, numberN - 1, sum);
}
