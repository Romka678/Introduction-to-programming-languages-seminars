//Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.

int Read_number(string a)
{
    Console.WriteLine(a);
    return Convert.ToInt32(Console.ReadLine());
}
int Count_of_digits(int number)
{
    int k = 0;
    if(number == 0) k = 1;
    while(number != 0)
    {
        number = number/10;
        k+=1;
    }
    return k;
}

int number = Read_number("Введите число.");
number = Count_of_digits(number);
Console.WriteLine($"Количество цифр в числе : {number}.");