Console.WriteLine();
Console.Write("Введите число, будем проверять палиндром или нет: ");
int numberA = int.Parse(Console.ReadLine()!);
int temp = numberA;
int numberB = 0;

while(temp > 0)
{
    numberB = numberB * 10 + temp % 10;
    temp /= 10;
}

if(numberA == numberB) Console.WriteLine("Число " + numberA + " палиндром!");
else Console.WriteLine("Число " + numberA + " не палиндром.");