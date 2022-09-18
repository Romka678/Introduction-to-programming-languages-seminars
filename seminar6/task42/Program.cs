// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.

int Read_number(string a)
{
    Console.WriteLine(a);
    return Convert.ToInt32(Console.ReadLine());
}

int LenOfArray(int num)
{
    int length = 0;
    while(num != 0)
    {
        num/=2;
        length++;
    }
    return length;
}

void Swap_Arr(int [] arr)
{
    int i = 0;
    int tmp = 0;
    int l = arr.Length;
    while(i < l)
    {
        tmp=arr[i];
        arr[i]=arr[l-1];
        arr[l-1]=tmp;
        l-=1;
        i+=1;
    }
}

/*void ConvertfromDecimalToBinary(int a,int i, int[] arr)
{
    int res = 0;
    while(i < arr.Length)
    {
        arr[i]= a%2;
        res = a/2;
        a = res;
        i++;
        ConvertfromDecimalToBinary(a, i, arr);
    }
}*/
void PrintBinaryView(int number)
{
    if(number <= 0) return;
    PrintBinaryView(number/2);
    Console.Write(number%2);
}

//int a = Read_number("Введите число.");
PrintBinaryView(Read_number("Введите число"));
/*int[] arr = new int[LenOfArray(a)];
ConvertfromDecimalToBinary(a, 0, arr);
Swap_Arr(arr);
for(int i = 0; i < arr.Length; i++)
{
    Console.Write(arr[i]);
}*/
