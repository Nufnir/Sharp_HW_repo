void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while(index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

int OddAdder(int[] collection)
{
    int count = collection.Length;
    int position = 0;
    int oddSum = 0;
    while(position < count)
    {
        if(collection[position] % 2 != 0) oddSum += collection[position];
        position++;
    }
    return oddSum;
}

int[] array = new int[100];
FillArray(array);
Console.WriteLine();
Console.WriteLine($"Сумма нечётных чисел в массиве равна {OddAdder(array)}");
Console.WriteLine();