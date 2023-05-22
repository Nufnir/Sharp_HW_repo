void FillArray(int[,] matrix)
{
    for (int r = 0; r < matrix.GetLength(0); r++)
    {
        for (int c = 0; c < matrix.GetLength(1); c++)
        {
            matrix[r,c] = new Random().Next(1,9);
        }
    }
}

void PrintArray(int[,] matrix)
{
    for (int r = 0; r < matrix.GetLength(0); r++)
    {
        for (int c = 0; c < matrix.GetLength(1); c++)
        {
            Console.Write($"{matrix[r,c]} ");
        }
        Console.WriteLine();
    }
}

int SumLine(int[,] array, int r)
{
    int sum = array[r,0];
    for (int c = 1; c < array.GetLength(1); c++)
        {
        sum += array[r,c];
        }
    return sum;
}

int[,] mArray = new int[3, 4];

FillArray(mArray);

PrintArray(mArray);

Console.WriteLine();

int minSum = 1;

int sum = SumLine(mArray, 0);

for (int i = 1; i < mArray.GetLength(0); i++)
{
    if (sum > SumLine(mArray, i))
        {
        sum = SumLine(mArray, i);
        minSum = i+1;
        }
}

Console.WriteLine($"Строка c наименьшей суммой элементов: {minSum}");

