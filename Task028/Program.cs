﻿int MultiplyNumbers(int num)
{
    int mult = 1;
    for (int i = 1; i <= num; i++)
    {
        checked
        {
        mult = mult * i;
        }
    }
    return mult;
}

Console.WriteLine("Введите целое положительное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int result = MultiplyNumbers(number);
Console.WriteLine($"Произведение чисел от 1 до {number} = {result}");