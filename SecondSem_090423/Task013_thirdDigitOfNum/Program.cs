Console.WriteLine();
Console.Write("Введите число: ");
int numberA = int.Parse(Console.ReadLine()!);

if(numberA < 100) Console.WriteLine("Третьей цифры в числе нет.");
else
{
    int thirdDigit = numberA;
    while(thirdDigit > 999)
    {
        thirdDigit /= 10;
    }
    thirdDigit %= 10;
    Console.WriteLine("Третья цифра числа " + numberA + " это " + thirdDigit);
}