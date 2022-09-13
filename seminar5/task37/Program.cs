// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.

int[] SetArray()
{
    int[] arr = new int[11];
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

int[] GetNewArray(int[] arr)
{

    int[] new_array = new int[(arr.Length+1)/2];
    int j = arr.Length - 1;
    Console.WriteLine(j);
    for(int i = 0; i < new_array.Length; i++)
    {
        new_array[i] = arr[i]*arr[arr.Length - 1 - i];
    }
    if(arr.Length%2 != 0) new_array[new_array.Length-1] = arr[arr.Length/2];
    return new_array;
}

int[] arr = SetArray();
Console.WriteLine("Исходный массив : ");
ShowArray(arr);
int[] new_array = GetNewArray(arr);
Console.WriteLine("Новый массив : ");
ShowArray(new_array);