int CountDigits(int num)
{
    if (num == 0) return 1;
    int count = 0;
    while (num != 0)
    {
        num = num / 10;
        count = count + 1;
    }
    return count;
}

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int result = CountDigits(number);
Console.WriteLine($"Количество цифр в числе {number} равно {result}");
