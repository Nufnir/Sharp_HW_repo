Console.WriteLine();
Console.Write("Введите первое число: ");
int numberA = int.Parse(Console.ReadLine()!);
Console.WriteLine();
Console.Write("Введите второе число: ");
int numberB = int.Parse(Console.ReadLine()!);
Console.WriteLine();
Console.Write("Введите третье число: ");
int numberC = int.Parse(Console.ReadLine()!);
int resultmax = numberA;

if (numberA < numberB) resultmax = numberB;

if (resultmax < numberC) resultmax = numberC;

Console.WriteLine();
Console.WriteLine("Максимальное число из введённых " + numberA + " , " + numberB + " и " + numberC + " равно " + resultmax + ".");
Console.WriteLine();