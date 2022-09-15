// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

int[] SetArray()
{
    int[] arr = new int[10];
    Random rand = new Random();
    for(int i = 0; i < arr.Length; i++)
    {
        arr[i] = rand.Next(1,11);
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

int SummNumber(int[] arr)
{
    int sum = 0;
    for(int i = 1; i < arr.Length; i+=2)
    {
        sum+=arr[i];
    }
    return sum;
}

int[] arr = SetArray();
int sum = SummNumber(arr);
ShowArray(arr);
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях : {sum}");