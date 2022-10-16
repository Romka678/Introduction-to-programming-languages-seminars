void CreateArrayOfShortString(string [] str, string [] arr)
{
    int j = 0;
    for(int i = 0; i < str.Length; i++)
    {
        if(str[i].Length <= 3)
        {
            arr[j] = str[i];
            j++;
        }
    }
    ShowArray(arr);
}

int GetLengthForNewArray(string [] str)
{
    int k = 0;
    for(int i = 0; i < str.Length; i++)
    {
        if(str[i].Length <= 3)
        {
            k++;
        }
    }
    return k;
}

void ShowArray(string [] str)
{
    Console.Write("[");
    Console.Write(string.Join("," , str));
    Console.WriteLine("]");
}


string [] str1 = {"123", "Home", "W"};
string [] str2 = {"1234", "Home", "World"};
string [] str3 = {"123", "God", "Sun"};

string [] arr1 = new string[GetLengthForNewArray(str1)];
string [] arr2 = new string[GetLengthForNewArray(str2)];
string [] arr3 = new string[GetLengthForNewArray(str3)];

Console.WriteLine("Пример 1 (Исходный массив : {123, Home, W}");
CreateArrayOfShortString(str1, arr1);
Console.WriteLine("Пример 2 (Исходный массив : {1234, Home, World}");
CreateArrayOfShortString(str2, arr2);
Console.WriteLine("Пример 3 (Исходный массив : {123, God, Sun}");
CreateArrayOfShortString(str3, arr3);