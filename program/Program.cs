// Массив сортируется по количеству символов элемента (<=3)

// Console.WriteLine("Введите количество элементов в массиве");
// int n=Convert.ToInt32(Console.ReadLine());
// string[] array = new string[n];

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
        for (int i = 0; i < array.Length; i++)
        Console.WriteLine("array[{0}] = {1}", i, array[i]);
        Console.ReadKey();


       

