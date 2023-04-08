Console.WriteLine();
Console.Write("Введите первое число: ");
int numberA = int.Parse(Console.ReadLine()!);
Console.WriteLine();
Console.Write("Введите второе число: ");
int numberB = int.Parse(Console.ReadLine()!);
int resultmax = numberA;
int resultmin = numberB;

if (numberA < numberB)
{
    resultmax = numberB;
    resultmin = numberA;
}

Console.WriteLine();
Console.WriteLine("Максимальное число из " + numberA + " и " + numberB + " равно " + resultmax + ". " + "Минимальное число равно " + resultmin + ".");
Console.WriteLine();