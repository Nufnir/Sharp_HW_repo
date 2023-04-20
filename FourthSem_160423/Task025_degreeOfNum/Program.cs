double DegreeOfNum(double arg1, double arg2)
{
    double result = Math.Pow(arg1, arg2);
    return result;
}

Console.WriteLine();
Console.Write("Введите число, которое нужно возвести в степень: ");
double number = double.Parse(Console.ReadLine()!);
Console.WriteLine();
Console.Write("Введите степень, в которую нужно возвести число: ");
double degree = double.Parse(Console.ReadLine()!);
double degNum = DegreeOfNum(number, degree);
Console.WriteLine();
Console.WriteLine($"Число {number} в степени {degree} равно {degNum}");
Console.WriteLine();