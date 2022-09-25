// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
//массив размером 2 x 2 x 2

int UnicRandomNumber(int[,,] arr,int i, int j, int k)
{
    Random rand = new Random();
    int num = rand.Next(10,100);
    for(i = 0; i < arr.GetLength(0) ; i++)
    {
        for(j = 0; j < arr.GetLength(1); j++)
        {
            for(k = 0; k < arr.GetLength(2); k++)
            {
                if(num == arr[i,j,k]) arr[i,j,k] = UnicRandomNumber(arr,i,j,k);
            }
        }
    }
    return num;
}

int[,,] FillMatrix(int a, int b , int c)
{
    int[,,] matrix = new int[a,b,c];
    Random rand = new Random();
    
    for(int i = 0; i < matrix.GetLength(0) ; i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            for(int k = 0; k < matrix.GetLength(2); k++)
            {
                matrix[i,j,k] = UnicRandomNumber(matrix,i,j,k);
            }
        }
    }
    return matrix;
}

void PrintMatrix(int[,,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0) ; i++)
    {
        Console.WriteLine();
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            for(int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.Write(matrix[i,j,k] +"("+ i + j + k + ")" + " ");
            }
        }
    }
    Console.WriteLine();
}

int[,,] matrix1 = FillMatrix(2, 2, 2);
PrintMatrix(matrix1);