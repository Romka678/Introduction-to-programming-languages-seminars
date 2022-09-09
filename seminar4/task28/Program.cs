// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.

int Read_number(string a)
{
    Console.WriteLine(a);
    return Convert.ToInt32(Console.ReadLine());
}
int Multiplication(int n)
{
    int res = 1;
    if(n > 0)
    {
        while(0 != n)
        {
            res = res * n;
            n-=1;
        }
    }
    else
    {
        res = 0;
    }
    return res;
} 

int number = Read_number("Введите число.");
int res = Multiplication(number);
Console.WriteLine($"Произведение чисел от 1 до {number} : {res}.");