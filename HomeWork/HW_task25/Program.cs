// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

int Read_number(string a)
{
    Console.WriteLine(a);
    return Convert.ToInt32(Console.ReadLine());
}

int Pow_number(int a, int b)
{
    int res = 1;
    int i = 0;
    if(b == 0) res = 0;
    while(i < b)
    {
        res = res * a;
        i+=1;
    }
    return res;
}
int a = Read_number("Введите первое число.");
int b = Read_number("Введите второе натуральное число.");
while(b < 0)
{
    Console.WriteLine("Вы ввели не натуральное число.");
    b = Read_number("Введите второе натуральное число.");
}
Console.WriteLine($"число {a} в натуральную степень {b} = " + Pow_number(a, b));