int RandomNumbers(int min, int max)
{
    Random rnd = new Random();
    int num = rnd.Next(min, max);
    return num;
}

int EnterNum(string text)
{
    System.Console.WriteLine(text);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int[,] arrayFilling(int lines, int columns)
{
    int[,] myArray = new int[lines, columns];

    for (int i = 0; i < myArray.GetLength(0); i++)
    {
        for (int j = 0; j < myArray.GetLength(1); j++)
        {
            myArray[i, j] = RandomNumbers(-10, 10);
        }
    }
    return myArray;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < 0)
            {
                System.Console.Write($"{array[i, j]}\t");
            }
            else
            {
                System.Console.Write($"{array[i, j]}\t");
            }
        }
        System.Console.WriteLine();
    }
}

bool Validating(int EnterUserLines, int EnterUserColumns, int[,] array)
{
    if (EnterUserLines > array.GetLength(0) || EnterUserColumns > array.GetLength(1))
    {
        return false;
    }
    return true;
}

void PrintUserNum(int EnterUserLines, int EnterUserColumns, int[,] array)
{
    if (Validating(EnterUserLines, EnterUserColumns, array))
    {
        System.Console.WriteLine($"В заданной ячейке, находится число: {array[EnterUserLines, EnterUserColumns]}");
        return;
    }
    System.Console.WriteLine("Такого числа в массиве нет");

}

int EnterUserLines = EnterNum("Введите строку => ");

int EnterUserColumns = EnterNum("Введите столбец => ");

int[,] myArray = arrayFilling(RandomNumbers(2, 10), RandomNumbers(2, 10));

System.Console.WriteLine();

PrintArray(myArray);

System.Console.WriteLine();

PrintUserNum(EnterUserLines, EnterUserColumns, myArray);