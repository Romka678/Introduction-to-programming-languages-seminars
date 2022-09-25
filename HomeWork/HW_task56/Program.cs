// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int[,] FillMatrix()
{
    int[,] matrix = new int[4,4];
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

void SumOfMatrixRow(int[,] matrix)
{
    int min = 0;
    int str = 0;
    for(int i = 0; i < matrix.GetLength(0) ; i++)
    {
        int sum = 0;
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            sum = sum + matrix[i,j];
            if(i == 0)
            {
                min = sum;
                str = i;
            }
        }
        if(sum < min)
        {
            min = sum;
            str = i + 1;
        } 
    }
    Console.WriteLine($"Минимальная сумма элементов в {str} строке и равна = {min}");
}

int[,] matrix = FillMatrix();
PrintMatrix(matrix);
SumOfMatrixRow(matrix);