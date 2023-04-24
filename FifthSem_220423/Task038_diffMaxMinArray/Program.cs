void FillArray(double[] collection)
{
    int length = collection.Length;
    int index = 0;
    while(index < length)
    {
        collection[index] = new Random().NextDouble();
        index++;
    }
}

double MaxFinder(double[] collection)
{
    int count = collection.Length;
    int position = 0;
    double max = collection[position];
    while(position < count)
    {
        if(collection[position] > max) max = collection[position];
        position++;
    }
    return max;
}

double MinFinder(double[] collection)
{
    int count = collection.Length;
    int position = 0;
    double min = collection[position];
    while(position < count)
    {
        if(collection[position] < min) min = collection[position];
        position++;
    }
    return min;
}

double[] array = new double[10];
FillArray(array);
Console.WriteLine();
Console.WriteLine($"Разность между максимальным и минимальным элементом массива равно {MaxFinder(array) - MinFinder(array)}");
Console.WriteLine();