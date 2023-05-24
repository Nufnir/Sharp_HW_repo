string Ret(int a, int b)
{
    if (a <= b) return Ret(a + 1, b) + $"{a} ";
    else return String.Empty;
}


int numberM = 1;

Console.WriteLine();

Console.Write($"Введите число, от которого нужно будет считать до {numberM}: ");

int numberN = int.Parse(Console.ReadLine()!);

Console.WriteLine();

Console.Write("Считаем: ");

Console.WriteLine(Ret(numberM, numberN));

Console.WriteLine();