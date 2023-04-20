Console.WriteLine();
Console.Write("Введите число N для вывода кубов чисел от 1 до N: ");
int numberA = int.Parse(Console.ReadLine()!);
int indexNum = 1;
int cubeNum;

while (indexNum <= numberA)
{
    cubeNum = indexNum * indexNum * indexNum;
    Console.WriteLine(indexNum + " в кубе равно " + cubeNum);
    indexNum++;
}