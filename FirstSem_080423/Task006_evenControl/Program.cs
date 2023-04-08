Console.WriteLine();
Console.Write("Введите число: ");
int numberA = int.Parse(Console.ReadLine()!);

if (numberA % 2 == 0)
{
    Console.WriteLine();
    Console.WriteLine("Введённое число " + numberA + " чётное" + ".");
    Console.WriteLine();
}
else
{
    Console.WriteLine();
    Console.WriteLine("Введённое число " + numberA + " нечётное" + ".");
    Console.WriteLine();
}