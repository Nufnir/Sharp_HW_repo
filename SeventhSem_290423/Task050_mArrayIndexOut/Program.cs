void FillArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = new Random().Next(1,9);
        }
    }
}

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j]} ");
        }
        Console.WriteLine();
    }
}

int UserInput(string output)
{
    System.Console.Write(output);
    string input = Console.ReadLine()!;
    int result = Convert.ToInt32(input);
    return result;
}

int[,] mArray = new int[3, 4];

FillArray(mArray);

int matrixRow = UserInput("Введите номер строки >> ");

int matrixColumn = UserInput("Введите номер столбца >> ");

PrintArray(mArray);

Console.WriteLine(mArray[matrixRow, matrixColumn]);