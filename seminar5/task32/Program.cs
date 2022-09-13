// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
//4; массив [6, 7, 19, 345, 3] -> нет
//-3; массив [6, 7, 19, 345, 3] -> да

int Read_number(string a)
{
    Console.WriteLine(a);
    return Convert.ToInt32(Console.ReadLine());
}

string ShowArray(int[] arr)
{
    string str = "";
    for(int i = 0; i < arr.Length; i++)
    {
        str = str + arr[i] + " ";
    }
    return str;
}

int [] Fill_array()
{
    int n = Read_number("Введите размер массива.");
    int [] arr = new int[n];
    for(int i = 0; i < arr.Length ; i++)
    {
        arr[i] = Read_number("Введите число.");
    }
    return arr;
}

string FindNumber(int[] arr, int a)
{
    string str = "Нет";
    for(int i = 0; i < arr.Length ; i++)
    {
        if(a == arr[i]) str = "Да";
    }
    return str;
}

int[] arr = Fill_array();
Console.WriteLine(ShowArray(arr));
int k = Read_number("Введите число, которое хотите найти.");
Console.WriteLine(FindNumber(arr,k));