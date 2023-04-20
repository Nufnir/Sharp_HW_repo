int SumDigits(int num)
{
    int result = 0;
    while(num > 0)
    {
        result += num % 10;
        num = num / 10;
    }
    return result;
}

Console.WriteLine();
Console.Write("Введите число, а мы просуммируем цифры числа: ");
int number = int.Parse(Console.ReadLine()!);
int sumDigits = SumDigits(number);
Console.WriteLine();
Console.WriteLine($"Сумма чисел в числе {number} равна {sumDigits}");
Console.WriteLine();