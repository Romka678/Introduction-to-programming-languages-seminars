// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи.

int Read_number(string a)
{
    Console.WriteLine(a);
    return Convert.ToInt32(Console.ReadLine());
}

string Fibbonachi(int n)
{
    string str = "0 1 ";
    int a = 0;
    int b = 1;
    int c = 0;
    if(n == 1) return "0";
    else if (n == 2) return "0 1";
    else if (n == 0) return "Ничего не вывел.";
    for(int i = 2; i < n; i++)
    {   c = a + b;
        str +=Convert.ToString(c) + " ";
        a = b;
        b = c;
    }
    return str;
}

int a = Read_number("Введите число.");
string str = Fibbonachi(a);
Console.WriteLine(str);