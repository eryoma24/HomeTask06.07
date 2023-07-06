int RandomNumbers(int min, int max)
{
    Random rnd = new Random();
    int num = rnd.Next(min, max);
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

void Print2DArray(int[,] array)
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
                System.Console.WriteLine($"{array[i, j]}\t");
            }
        }
        System.Console.WriteLine();
    }
}

void PrintArray(double[] array)
{
    System.Console.WriteLine("Среднее арифметическое каждого столбца => ");

    for (int j = 0; j < array.Length; j++)
    {
        if (array[j] < 0)
        {
            System.Console.WriteLine($"{array[j]}\t");
        }
        else
        {
            System.Console.WriteLine($" {array[j]}\t");
        }
    }
    System.Console.WriteLine();
}

int[] sumOfColumns(int[,] myArray)
{
    int[,] array = myArray;
    int size = array.GetLength(1);

    int[] columnSums = new int[size];

    for (int i = 0; i < array.GetLength(1); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(0); j++)
        {
            sum = sum + array[j, i];
        }
        columnSums[i] = sum;
    }
    return columnSums;
}

double[] ArithmeticMeanOfColumns(int[] array, int[,] args)
{
    double[] ArithmeticMeanOfColumn = new double[array.Length];

    double y = (double) args.GetLength(0);

    for(int i = 0; i < array.Length; i++)
    {
        double x = (double) array[i];

        ArithmeticMeanOfColumn[i] = Math.Round((x / y), 2);
    }
    return ArithmeticMeanOfColumn;
}

int[,] myArray = arrayFilling(RandomNumbers(2, 10), RandomNumbers(2, 10));
int[] myArgs = sumOfColumns(myArray);

Print2DArray(myArray);

System.Console.WriteLine();

double[] ArithmeticMean = ArithmeticMeanOfColumns(myArgs, myArray);

PrintArray(ArithmeticMean);