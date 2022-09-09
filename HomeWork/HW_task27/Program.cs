// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int Read_number(string a)
{
    Console.WriteLine(a);
    return Math.Abs(Convert.ToInt32(Console.ReadLine()));
}
int Summ(int num)
{
    int count = 0;
    int k = 1;
    int number = num;
    int sum = 0;
    int result;
    int i = 0;

    while(num != 0)
    {
        num = num/10;
        count+=1;
        k*=10;
    }

    while(i <= count)
    {
        number = Math.DivRem(number, k, out result);
        sum = sum + number;
        number = result;
        i+=1;
        k/=10;
    }
    return sum;
}

int a = Read_number("Введите первое число.");
int sum = Summ(a);
Console.WriteLine($"Сумма цифр в числе = {sum}");