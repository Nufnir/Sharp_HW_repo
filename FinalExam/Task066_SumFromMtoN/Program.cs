int numberM = 0;
int numberN = 0;


int Sum(int n)
{
    if (n == numberM) return numberM;
    else return n + Sum(n - 1);
}


Console.WriteLine();

Console.Write($"Введите число M: ");

numberM = int.Parse(Console.ReadLine()!);

Console.WriteLine();

Console.Write($"Введите число N: ");

numberN = int.Parse(Console.ReadLine()!);

Console.WriteLine();

Console.WriteLine($"Сумма чисел от {numberM} до {numberN} равна {Sum(numberN)}");

Console.WriteLine();