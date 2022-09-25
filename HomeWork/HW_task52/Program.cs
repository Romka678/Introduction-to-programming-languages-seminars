// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int[,] FillMatrix()
{
    int[,] matrix = new int[3,4];
    Random rand = new Random();
    
    for(int i = 0; i < matrix.GetLength(0) ; i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = rand.Next(0, 11);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0) ; i++)
    {
        Console.WriteLine();
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i,j] + " ");
        }
    }
    Console.WriteLine();
}

void ArithmeticMeanOfMatrix(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(1) ; i++)
    {
        double sum = 0;
        for(int j = 0; j < matrix.GetLength(0); j++)
        {
            sum = sum + matrix[j,i];
        }
        Console.WriteLine($"Среднее арифметическое в {i + 1} столбце = {Math.Round(sum/(matrix.GetLength(1) - 1),3)}");
    }
}

int[,] matrix = FillMatrix();
PrintMatrix(matrix);
ArithmeticMeanOfMatrix(matrix);