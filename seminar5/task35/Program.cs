// Задача 35: Задайте одномерный массив из 123 случайных чисел в диапазоне [0, 150].
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99].

int[] SetArray()
{
    int[] arr = new int[123];
    Random rand = new Random();
    for(int i = 0; i < arr.Length; i++)
    {
        arr[i] = rand.Next(0,151);
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

int GetNumberElements(int[] arr)
{
    int count = 0;
    for(int i = 0; i < arr.Length; i++)
    {
        if((arr[i] >= 10) && (arr[i] <= 99)) count++;
    }
    return count;
}

int[] arr = SetArray();
int count = GetNumberElements(arr);
ShowArray(arr);
Console.WriteLine($"Количество элементов массива, значения которых лежат в отрезке [10,99] {count}");