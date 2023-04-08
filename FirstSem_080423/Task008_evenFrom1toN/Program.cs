Console.WriteLine();
Console.Write("Введите число: ");
int numberA = int.Parse(Console.ReadLine()!);
int bufferNumber = 1;
Console.WriteLine();
Console.WriteLine("Чётные числа от " + bufferNumber + " до " + numberA + ":");

while (bufferNumber <= numberA)
{
    if (bufferNumber % 2 == 0)
    {
        Console.Write(bufferNumber + " ");
    }
bufferNumber++;
}
Console.WriteLine();