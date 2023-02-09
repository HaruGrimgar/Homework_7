/* Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет. */

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

bool CheckExistenseOfElement(int[,] matrix, int row, int column)
{
    if (matrix.GetLength(0) >= row && matrix.GetLength(1) >= column) return true; // >= так как отсчёт начинается с 1, а не с 0
    else return false;
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

int[,] matrix = CreateMatrix(5, 5); // сразу создаём матрицу 5х5
PrintMatrix(matrix);
Console.WriteLine();
int row = InputInt("Введите ряд, элемента, который вы ищите");
int column = InputInt("Введите столбец, элемента, который вы ищите");
// Вычитаем единицу, так как компьютер начинает отсчёт с 0, а пользователь с 1
if (CheckExistenseOfElement(matrix, row, column)) Console.WriteLine($"элемент по ({row},{column}) = {matrix[row - 1, column - 1]}"); 
else Console.WriteLine($"элемент по ({row},{column}) -> не существует");