// Массив сортируется по количеству символов элемента (<=3)


string[] array; // ссылка на массив строк
int n; // количество строк в массиве
string s; // строка
string[] array_2; // дополнительная переменная-ссылка 

Console.WriteLine("Введите элементы массива");
n = 0; 
array = new string[n]; 

    do
    {
        s = Console.ReadLine();
        if (s!="")
        {
          n++;
          array_2 = new string[n];
          for (int i = 0; i < array_2.Length - 1; i++)
            array_2[i] = array[i];
            array_2[n - 1] = s;
            array = array_2;
        }
    } 
    while (s!= "");
    Console.WriteLine("Исходный массив: ");
        for (int i = 0; i < array.Length; i++)
        {
            if (i!=array.Length-1) Console.Write($"{array[i]}, ");
            else Console.WriteLine($"{array[i]}");
        }
        
       Console.WriteLine("Отсортированный массив:");
        for (int i = 0; i < array.Length; i++)
            {
                if ((array[i].Length)<=3) Console.Write(array[i]+" ");
            }

