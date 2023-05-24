UInt64 A(UInt64 m, UInt64 n)
{
    if (m == 0) return n + 1;
    if (m > 0 && n == 0) return A(m - 1, 1);
    return A(m - 1, A(m, n - 1));
}


Console.WriteLine();

Console.Write($"Введите число M: ");

UInt64 numberM = UInt64.Parse(Console.ReadLine()!);

Console.WriteLine();

Console.Write($"Введите число N: ");

UInt64 numberN = UInt64.Parse(Console.ReadLine()!);

Console.WriteLine();

Console.WriteLine($"Функция Аккермана от чисел {numberM} и {numberN} равна {A(numberM, numberN)}");

Console.WriteLine();
