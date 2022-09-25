// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int Read_number(string a)
{
    Console.WriteLine(a);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] FillMatrix(int a, int b)
{
    int[,] matrix = new int[a,b];
    Random rand = new Random();
    
    for(int i = 0; i < matrix.GetLength(0) ; i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = rand.Next(1, 5);
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

int[,] MultiplicationOfMatrix(int[,] matrix1, int[,] matrix2)
{
    int[,] matrix3 = new int[matrix1.GetLength(0),matrix2.GetLength(1)];

    for(int i = 0; i < matrix1.GetLength(0) ; i++)
    {
        for(int j = 0; j < matrix2.GetLength(1) ; j++)
        {
            for(int k = 0; k < matrix2.GetLength(0); k++)
            {
                matrix3[i,j] = matrix3[i,j] + matrix1[i,k] * matrix2[k,j];
            }
        }
    }
    return matrix3;
}

int a = Read_number("Введите количество строк первой матрицы.");
int b = Read_number("Введите количество столбцов первой матрицы.");
int c = Read_number("Введите количество строк второй матрицы.");
int d = Read_number("Введите количество столбцов второй матрицы.");
while(b != c)
{
    Console.WriteLine("Количество строк первой матрицы должно равняться количеству столбцов второй матрицы.");
    a = Read_number("Введите количество строк первой матрицы.");
    b = Read_number("Введите количество столбцов первой матрицы.");
    c = Read_number("Введите количество строк второй матрицы.");
    d = Read_number("Введите количество столбцов второй матрицы.");
}
int[,] matrix1 = FillMatrix(a, b);
PrintMatrix(matrix1);
Console.WriteLine();
int[,] matrix2 = FillMatrix(c, d);
PrintMatrix(matrix2);
Console.WriteLine();
int[,] matrix3 = MultiplicationOfMatrix(matrix1,matrix2);
PrintMatrix(matrix3);