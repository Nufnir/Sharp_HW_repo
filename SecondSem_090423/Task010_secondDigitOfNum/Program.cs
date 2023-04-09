Console.WriteLine();
Console.Write("Введите трёхзначное число: ");
int numberA = int.Parse(Console.ReadLine()!);

if(numberA > 999 || numberA < 100) Console.WriteLine("Ввод неверный.");
else
{
    Console.WriteLine("Введено число " + numberA);
    int secondDigit = numberA / 10 % 10;
    Console.WriteLine("Вторая цифра в числе: " + secondDigit);
}