/* Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
*/

int InputInt(string message)
{
    Console.Write($"{message} -> ");
    return Convert.ToInt32(Console.ReadLine());
}

int[,] CreateMatrix(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = new Random().Next(-15, 16);
        }
    }
    return matrix;
}

double[] GetMeanOfColumns(int[,] matrix) // 
{
    int rows = matrix.GetLength(0);
    int columns = matrix.GetLength(1);
    double[] AverageOfColumns = new double[columns];
    for (int j = 0; j < columns; j++)
    {
        for (int i = 0; i < rows; i++)
        {
            AverageOfColumns[j] += matrix[i,j]; // суммируем все элементы столба
        }
        AverageOfColumns[j] = Math.Round(AverageOfColumns[j] / rows, 1); // делим сумму на количество элементов
    }
    return AverageOfColumns;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j]}\t");
        }
        Console.WriteLine();
    }
}

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
            Console.Write($"{array[i]}\t");
    }
    Console.WriteLine();
}

int m = InputInt("Введите количество строк массива");
int n = InputInt("Введите количество столбцов массива");
int[,] matrix = CreateMatrix(m, n);
double[] AverageOfColumns = GetMeanOfColumns(matrix);
Console.WriteLine("Матрица:");
PrintMatrix(matrix);
Console.WriteLine("Среднее арифметическое столбиков матрицы:");
PrintArray(AverageOfColumns);