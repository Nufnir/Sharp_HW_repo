void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while(index < length)
    {
        collection[index] = new Random().Next(100, 999);
        index++;
    }
}

int EvenCounter(int[] collection)
{
    int count = collection.Length;
    int position = 0;
    int evenCount = 0;
    while(position < count)
    {
        if(collection[position] % 2 == 0) evenCount++;
        position++;
    }
    return evenCount;
}

int[] array = new int[100];
FillArray(array);
Console.WriteLine();
Console.WriteLine($"Количество чётных чисел в массиве равно {EvenCounter(array)}");
Console.WriteLine();