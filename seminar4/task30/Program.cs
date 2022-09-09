// Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.

string Random_array()
{
    int [] arr = new int[8];
    int i = 0;
    Random rnd = new Random();
    while(i < 8)
    {
        arr[i] = rnd.Next(0,2);
        i+=1;
    }
    i = 0;
    string str = "[";
    while(i < arr.Length)
    {
      str = str + arr[i];
      if(i < 7) str = str + ",";
      i+=1;
    }
    str = str + "]";
    return str;
}

string str = Random_array();
Console.WriteLine(str);
