Console.WriteLine("Введите координатную четверть.");
int x = Convert.ToInt32(Console.ReadLine());
while(x < 1 || x > 4)
{
    Console.WriteLine("Число неверное");
    Console.WriteLine("Введите координатную четверть.");
    x = Convert.ToInt32(Console.ReadLine());
}
switch (x)
{
    case 1:
        Console.WriteLine("Диапазон x > 0 и y > 0");
        break;
    case 2:
        Console.WriteLine("Диапазон x < 0 и y > 0");
        break;
    case 3:
        Console.WriteLine("Диапазон x < 0 и y < 0");
        break;
    case 4:
     Console.WriteLine("Диапазон x > 0 и y < 0");
        break;
}