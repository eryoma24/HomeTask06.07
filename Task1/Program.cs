double RandomRealNumbers()
{
    Random rnd = new Random();
    double num = rnd.NextDouble();
    double whol = rnd.Next(-10, 10);
    double numbers = Math.Round(num + whol, 1);
    return numbers;
}

int EnterNum(string text)
{
    System.Console.WriteLine(text);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

double[,] arrayFIlling(int lines, int columns)
{
    double[,] myArray = new double[lines, columns];

    for (int i = 0; i < myArray.GetLength(0); i++)
    {
        for (int j = 0; j < myArray.GetLength(1); j++)
        {
            myArray[i, j] = RandomRealNumbers();
        }
    }
    return myArray;
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < 0)
            {
                System.Console.WriteLine($"{array[i, j]}\t");
            }
            else
            {
                System.Console.WriteLine($" {array[i, j]}\t");
            }
        }
        System.Console.WriteLine();
    }
}

int ValidatingParameterLines(int lines)
{
    if(lines < 2)
    {
        lines = ValidatingParameterLines(EnterNum("Введите количество строк => "));
    }
    return lines;
}

int ValidatingParameterColumns(int columns)
{
    if (columns < 2)
    {
        columns = ValidatingParameterColumns(EnterNum("Введите количество столбцов => "));
    }
    return columns;
}

int lines = ValidatingParameterLines(EnterNum("Введите количество строк => "));
int columns = ValidatingParameterColumns(EnterNum("Введите количество столбцов => "));

double[,] arrayWithRealNumbers = arrayFIlling(lines, columns);

PrintArray(arrayWithRealNumbers);