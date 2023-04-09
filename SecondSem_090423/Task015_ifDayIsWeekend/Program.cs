Console.WriteLine();
Console.Write("Введите номер дня недели: ");
int numberA = int.Parse(Console.ReadLine()!);

if(numberA < 1 || numberA > 7) Console.WriteLine("Такого дня в неделе нет.");
else
{
    if(numberA >= 6) Console.WriteLine("Ура! Выходной!");
    else Console.WriteLine("Серые будни :(");
}