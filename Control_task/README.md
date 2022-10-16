# Описание работы программы
 ## 1.   Метод получения длинны для нового массива.

    int GetLengthForNewArray(string [] str)
    {
    int k = 0;
    for(int i = 0; i < str.Length; i++)
    {
        if(str[i].Length <= 3)
        {
            k++;
        }
    }
    return k;
    }
На вход поступает исходный массив. Создаем переменную счетчик k. Идем по всему массиву и если длина элемента массива меньше или равна 3, то увеличиваем счетчик. Затем, после всех действий, возвращаем счетчик.
## 2.   Основной метод, в котором происходит формирование массива из элементов, длина которых равна или меньше 3.

    void CreateArrayOfShortString(string [] str, string [] arr)
    {
    int j = 0;
    for(int i = 0; i < str.Length; i++)
    {
        if(str[i].Length <= 3)
        {
            arr[j] = str[i];
            j++;
        }
        if(j > arr.Length) break;
    }
    ShowArray(arr);
    }
На вход поступает два массива str (исходный) и arr (получившийся в ходе работы программы). Создаем переменную j = 0, которая идет по массиву arr. Далее в цикле идем по массиву str и если длина элемента массива str меньше или равна 3, то записываем его в массив arr и увеличиваем j. Далее следует условие, если j больше длины массива arr, то мы заподнили его полностью и выходим из цикла. Затем следует метод ShowArray, который вывод полученный массив (arr) на экран, данный метод будет описан далее.
## 3.   Метод, который выводит массив на экран.
    void ShowArray(string [] str)
    {
    Console.Write("[");
    Console.Write(string.Join("," , str));
    Console.WriteLine("]");
    }
На вход поступает массив, выводим сначала "[", затем добавляем в массив "," с помощью функции Join и выводим массив, последним выводим "]".
## 4.   Основной блок программы.

    string [] str1 = {"123", "Home", "W"};
    string [] str2 = {"1234", "Home", "World"};
    string [] str3 = {"123", "God", "Sun"};

    string [] arr1 = new string[GetLengthForNewArray(str1)];
    string [] arr2 = new string[GetLengthForNewArray(str2)];
    string [] arr3 = new string[GetLengthForNewArray(str3)];

    Console.WriteLine("Пример 1 (Исходный массив : {123, Home, W}");
    CreateArrayOfShortString(str1, arr1);
    Console.WriteLine("Пример 2 (Исходный массив : {1234, Home, World}");
    CreateArrayOfShortString(str2, arr2);
    Console.WriteLine("Пример 3 (Исходный массив : {123, God, Sun}");
    CreateArrayOfShortString(str3, arr3);
Создаем 3 массива (str1, str2, str3), они уже заполнены.
Затем используя метод, описанный в пункте 1 создаем 3 массива нужной длины (arr1, arr2, arr3), это массивы, которые мы заполним в результате выполнения программы. Далее выводится информация на экран и выводится результат применения функции CreateArrayOfShortString.