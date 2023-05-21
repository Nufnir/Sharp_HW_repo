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

void PrintArrayColMean(int[,] matrix)
{
    for (int c = 0; c < matrix.GetLength(1); c++)
    {
        int sum = 0;
        double avg = 0;
        for (int r = 0; r < matrix.GetLength(0); r++)
        {
            sum += matrix[r,c];
        }
        avg = (double) sum / matrix.GetLength(0);
        Console.WriteLine(avg);
    }
}


int[,] mArray = new int[3, 4];

FillArray(mArray);

PrintArray(mArray);

Console.WriteLine();

PrintArrayColMean(mArray);