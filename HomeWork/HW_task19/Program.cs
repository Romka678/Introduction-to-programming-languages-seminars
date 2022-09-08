// Задача 19
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
class Program{
static int [] Swap_Arr(int [] arr)
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
    return arr;
}
static bool Comp_arr(int [] a,int [] b)
{
    int i = 0;
    bool res = true;
    int l = a.Length;
    while(i < l)
    {
        if(a[i] != b[i])
        {
            res = false;
            i = l;
        }
        else i+=1;
    }
    return res;
}
static void Main(String[] args)
    {
        Console.WriteLine("Введите пятизначное число.");
        int num = Convert.ToInt32(Console.ReadLine());
        while(num < 10000 || num > 99999 || num < 0)
        {
            Console.WriteLine("Вы ввели неверное число(оно не пятизначное или отрицательное).");
            Console.WriteLine("Введите пятизначное число.");
            num = Convert.ToInt32(Console.ReadLine());
        }

        int i = 0;
        int k = 10000;
        int [] arr = new int [5];
        int [] new_arr = new int [5];
        int result;

        while(i < 5)
        {
            num = Math.DivRem(num, k, out result);
            arr[i] = num;
            new_arr[i] = num;
            num = result;
            i+=1;
            k/=10;
        }

        Swap_Arr(arr);

        i=0;
        if(Comp_arr(arr,new_arr))
        {
            Console.WriteLine("Число палиндром.");
        }
        else
        {
            Console.WriteLine("Число не палиндром.");
        }
    }
}