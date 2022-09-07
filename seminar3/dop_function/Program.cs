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
static void Main(String[] args)
    {
        int [] a = {1,2,3,4,5,6,7,8,9,-7};
        int i=0;
        Console.WriteLine("Исходный массив : ");
        while(i < a.Length)
        {
            Console.Write(" " + a[i]);
            i+=1;
        }
        Swap_Arr(a);
        i=0;
        Console.WriteLine("\n");
        Console.WriteLine("Развернутый массив : ");
        while(i < a.Length)
        {
            Console.Write(" " + a[i]);
            i+=1;
        }
    }
}