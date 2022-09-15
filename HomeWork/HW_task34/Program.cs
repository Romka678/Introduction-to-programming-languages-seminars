// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

int[] SetArray()
{
    int[] arr = new int[10];
    Random rand = new Random();
    for(int i = 0; i < arr.Length; i++)
    {
        arr[i] = rand.Next(100,1000);
    }
    return arr;
}

void ShowArray(int[] arr)
{
    string str = "";
    for(int i = 0; i < arr.Length; i++)
    {
        str = str + arr[i];
    }
    Console.WriteLine(string.Join("," , arr));
}

int GetNumber(int[] arr)
{
    int count = 0;
    for(int i = 0; i < arr.Length; i++)
    {
        if(arr[i]%2 == 0) count++;
    }
    return count;
}

int[] arr = SetArray();
int count = GetNumber(arr);
ShowArray(arr);
Console.WriteLine($"Количество четных элементов массива : {count}");