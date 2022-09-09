// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.Данные вводятся с консоли пользователем.

string Read_number(string a)
{
    Console.WriteLine(a);
    return Console.ReadLine();
}

string Fill_array()
{
    string res ="[";
    string [] values = new string[8];
    for(int i = 0; i < values.Length ; i++)
    {
        values[i] = Read_number("Введите число.");
    }
    res =res + string.Join(", ", values) + "]";

    return res;
}

string str = Fill_array();
Console.WriteLine(str);