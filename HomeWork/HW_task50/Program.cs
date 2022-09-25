// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.

int Read_number(string a)
{
    Console.WriteLine(a);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] FillMatrix()
{
    int[,] matrix = new int[5,5];
    Random rand = new Random();
    
    for(int i = 0; i < matrix.GetLength(0) ; i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = rand.Next(-100, 101);
        }
    }
    return matrix;
}

string FindNumberOfMatrix(int[,] matrix)
{
    string str = "Такого элемента нет, введите другой индекс.";
    int x = Read_number("Введите первый индекс элемента.");
    int y = Read_number("Введите второй индекс элемента.");

    while((x < 0 || y < 0)||(x >= matrix.GetLength(0) || y >= matrix.GetLength(1)))
    {
        Console.WriteLine("Один или оба индекса отрицательные или выходят за границы матрицы, введите другие индексы.");
        x = Read_number("Введите первый индекс элемента.");
        y = Read_number("Введите второй индекс элемента.");
    }

    for(int i = 0; i < matrix.GetLength(0) ; i++)
    {
        if(i == x)
        {
            for(int j = 0; j < matrix.GetLength(1); j++)
            {
                if(j == y)
                {
                    str = $"Элемент с индексами {x} и {y} = {matrix[i,j]}";
                }
            }
        }
    }
    return str;
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

int[,] matrix = FillMatrix();
PrintMatrix(matrix);
Console.WriteLine(FindNumberOfMatrix(matrix));