// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

int[] SetArray()
{
    int[] arr = new int[10];
    Random rand = new Random();
    for(int i = 0; i < arr.Length; i++)
    {
        arr[i] = rand.Next(1,100);
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

int ResultOfMaxAndMin(int[] arr)
{
    int res = 0;
    int min = arr[0];
    int max = arr[0];
    for(int i = 1; i < arr.Length; i++)
    {
        if(arr[i] > max) max = arr[i];
        else if(arr[i] < min) min = arr[i];
        
    }
    res = max - min;
    return res;
}

int[] arr = SetArray();
int res = ResultOfMaxAndMin(arr);
ShowArray(arr);
Console.WriteLine($"Разница между максимальным и минимальным элементами массива : {res}");