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

void Print2DArray(int[,] matrix)
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

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while(position < count)
    {
        Console.Write($"{col[position]} ");
        position++;
    }
    Console.WriteLine();
}

void PrintRow(int[,] matrix)
{
    for (int r = 0; r < matrix.GetLength(0); r++)
    {
        int[] array = new int[matrix.GetLength(1)];
        int i = 0;
        for (int c = 0; c < matrix.GetLength(1); c++)
        {
            array[i] = matrix[r,c];
            i++;
        }
        Console.Write($"Сортируем строку двумерного массива от меньшего к большему >> ");
        Array.Sort(array);
        PrintArray(array);
        }
}

int[,] mArray = new int[3, 4];

FillArray(mArray);

Print2DArray(mArray);

Console.WriteLine();

PrintRow(mArray);