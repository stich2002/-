// Массив сортируется по количеству символов элемента (<=3)

Console.WriteLine("Введите количество элементов в массиве");
int n=Convert.ToInt32(Console.ReadLine());
int[]array = new int[n];

for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-10000, 10000);
        if (i!=array.Length-1) Console.Write($"{array[i]}, ");
        else Console.WriteLine($"{array[i]}");
    }
