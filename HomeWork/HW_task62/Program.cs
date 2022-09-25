// Задача 62. Заполните спирально массив 4 на 4.

int[,] FillMatrix(int a, int b)
{
    int[,] matrix = new int[a,b];
    int i = 0;
    int x = matrix.GetLength(0);
    int x1 = 0;
    int y = matrix.GetLength(1);
    int y1 = 0;
    int j = 0;
    int k = 1;
    int count = 0;
    while(count < a/2+1)
    {
        for(j = j; j < x ; j++)
        {
            matrix[i,j] = k;
            k++;
        }
        x = x - 1;
        i++;
        j--;
        for(i = i; i < y; i++)
        {
            matrix[i,j] = k;
            k++;
        }
        j--;
        i--;
        y = y - 1;
        for(j = j; j >= x1; j--)
        {
            matrix[i,j] = k;
            k++;
        }
        i--;
        j++;
        for(i = i; i > y1; i--)
        {
            matrix[i,j] = k;
            k++;
        }
        i++;
        j++;
        count++;
        x1++;
        y1++;
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

int[,] matrix1 = FillMatrix(4, 4);
PrintMatrix(matrix1);