// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

double[,] FillMatrix()
{
    double[,] matrix = new double[5,5];
    Random rand = new Random();

    for(int i = 0; i < matrix.GetLength(0) ; i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = rand.Next(-100, 101)/10d;
        }
    }
    return matrix;
}

void PrintMatrix(double[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0) ; i++)
    {
        Console.WriteLine();
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i,j] + " ");
        }
    }
}

double[,] matrix = FillMatrix();
PrintMatrix(matrix);