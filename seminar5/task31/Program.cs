int [] Random_array()
{
    int [] arr = new int[12];
    int i = 0;
    Random rnd = new Random();
    while(i < 12)
    {
        arr[i] = rnd.Next(-9,10);
        i+=1;
    }
    i = 0;
    return arr;
}

int [] arr = Random_array();
int i = 0;
int sum_one = 0;
int sum_two = 0;
while(i < 12)
{
    Console.Write(" " + arr[i]);
    if(arr[i] < 0)
    {
        sum_one = sum_one + arr[i];
    }
    else
    {
        sum_two = sum_two + arr[i];
    }
    i+=1;
}
Console.WriteLine("Сумма положительных : " + sum_one);
Console.WriteLine("Сумма отрицательных : " + sum_two);