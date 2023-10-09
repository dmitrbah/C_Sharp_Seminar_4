﻿// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int Power(int A, int B)
{
    int res = A;
    for (int i = 1; i < B; i++)
    {
        res = res * A;
    }
    return res;
}

Console.WriteLine("Введите число A: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());

int result = Power(numberA, numberB);
Console.WriteLine($"Число {numberA} в степени {numberB} равно {result}");