// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// -1, -7, 567, 89, 223-> 3
int Prompt (string message)
{
    Console.WriteLine(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}
int[] CreateArray(int size)
{
    int[] array = new int [size];
    // Random random = new Random(); // оптимизация объекта Random (var - объект неявной типизации)
    for (int i = 0; i < array.Length; i++)
    {
       array[i] = Prompt($"Ведите {i + 1}-й элемент");
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

int CountPpsitiveNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++) 
    {
        if (array[i] > 0)
        {
            count++;
        }
        
    }
    return count;
}

int size = Prompt("Введите количество элементов >");
int[] array;
array = CreateArray(size);
PrintArray(array);
Console.WriteLine($"количество чисел больше 0 - {CountPpsitiveNumbers(array)}");