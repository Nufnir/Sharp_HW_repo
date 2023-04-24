int UserInput(string output)
{
    System.Console.Write(output);
    string input = Console.ReadLine()!;
    int result = Convert.ToInt32(input);
    return result;
}


int[] ArrayInput(int len)
{
    int[] array = new int[len];
    int index = 0;
    while(index < array.Length)
    {
        array[index] = UserInput($"Введите элемент №{index + 1} >> ");
        index++;
    }
    return array;
}

int CountPositive(int[] array)
{
    int count = 0;
    int index = 0;
    while(index < array.Length)
    {
        if(array[index] > 0) count++;
        index++;
    }
    return count;
}

Console.WriteLine();
int length = UserInput("Введите количество элементов массива >> ");
int[] array;
array = ArrayInput(length);
Console.WriteLine($"Количество элементов массива больше нуля равно {CountPositive(array)}");
Console.WriteLine();