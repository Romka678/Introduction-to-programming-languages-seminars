// Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

int[] SetArray()
{
    int[] arr = new int[10];
    Random rand = new Random();
    for(int i = 0; i < arr.Length; i++)
    {
        arr[i] = rand.Next(-10,11);
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
    Console.WriteLine(string.Join(", " , arr));
}

int[] CopyArray(int[] arr)
{
    int[] new_array = new int[arr.Length];
    for(int i = 0; i < arr.Length; i++)
    {
        new_array[i] = arr[i];
    }
    return new_array;
}

int[] arr = SetArray();
Console.WriteLine("Исходный массив : ");
ShowArray(arr);
int[] new_array = CopyArray(arr);
Console.WriteLine("Новый массив : ");
ShowArray(new_array);