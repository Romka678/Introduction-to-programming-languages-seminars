// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по возрастанию элементы каждой строки двумерного массива.

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

void BublleSort(int[] arr)
{
    for(int j = 0 ; j < arr.Length; j++)
    {
        for(int i = 0; i < arr.Length - 1; i++)
        {
            if(arr[i+1] < arr[i])
            {
                int tmp = arr[i];
                arr[i] = arr[i+1];
                arr[i+1] = tmp;
            }
        }
    }
}

void OrderedMatrix(int[,] matrix)
{
    int[] arr = new int[matrix.GetLength(1)];
    for(int i = 0; i < matrix.GetLength(0) ; i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            arr[j]= matrix[i,j];
        }
        BublleSort(arr);
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = arr[j];
        }
    }
}

int[,] matrix = FillMatrix();
PrintMatrix(matrix);
OrderedMatrix(matrix);
PrintMatrix(matrix);