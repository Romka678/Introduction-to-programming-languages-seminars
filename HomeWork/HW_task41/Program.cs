// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// Ввод чисел останавливается при помощи ввода стоп-слова "stop"

string Read_number(string a)
{
    Console.WriteLine(a);
    return Console.ReadLine();
}

string Count_Of_Number()
{
    int a = 0;
    int count = 0;
    string str = "";
    while(str != "stop")
    {
        str = Read_number("Введите число или stop, если хотите перестать вводить числа.");
        if(str == "stop") return "Пользователь ввёл " + count + " чисел больше 0.";
        else
        {
            a = Convert.ToInt32(str);
            if (a > 0) count++;
        }
    }

    return "Пользователь ввёл " + count + " чисел больше 0.";
}

Console.WriteLine(Count_Of_Number());