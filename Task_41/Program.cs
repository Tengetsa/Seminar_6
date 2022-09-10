// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.Write($"Введи число М (количество чисел): ");
int size = Convert.ToInt32(Console.ReadLine());
int[] NumberOfNumbers = new int[size];

void InputNumbers(int size)
{
    for (int i = 0; i < size; i++)
    {
        Console.Write($"Введи {i + 1}-ое число: ");
        NumberOfNumbers[i] = Convert.ToInt32(Console.ReadLine());
    }
}

void CountPositiveNumber(int[] array, int count = 0)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count += 1;
    }
    Console.WriteLine($"Чисел больше ноля {count}");
}

InputNumbers(size);
CountPositiveNumber(NumberOfNumbers);
