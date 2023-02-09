/* Задайте двумерный массив размером m×n, 
заполненный случайными вещественными числами. */
int InputInt(string message)
{
    Console.Write($"{message} -> ");
    return Convert.ToInt32(Console.ReadLine());
}

double[,] CreateMatrix(int rows, int columns)
{
    double[,] matrix = new double[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = new Random().Next(-15, 16) + Math.Round( new Random().NextDouble(), 1);
        }
    }
    return matrix;
}

void PrintMatrix(double[,] matrix)
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

int m = InputInt("Введите количество строк массива");
int n = InputInt("Введите количество столбцов массива");
double[,] matrix = CreateMatrix(m,n);
PrintMatrix(matrix);