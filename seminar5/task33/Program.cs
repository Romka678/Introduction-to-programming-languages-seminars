// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
//[-4, -8, 8, 2] -> [4, 8, -8, -2]

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

string ShowArray(int[] arr)
{
    string str = "";
    for(int i = 0; i < arr.Length; i++)
    {
        str = str + " " + arr[i];
    }
    return str;
}

void ChangeArrayNumber(int[] arr)
{
    int [] new_array = new int [arr.Length];
    for(int i = 0; i < arr.Length; i++)
    {
       arr[i] = -arr[i];
    }
}

int [] arr = SetArray();
Console.WriteLine(ShowArray(arr));
ChangeArrayNumber(arr);
Console.WriteLine(ShowArray(arr));