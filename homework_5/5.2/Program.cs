// Задача 2: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

void Print(int[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
        Console.Write($"{arr[i]} ");
    Console.WriteLine();
}

int[] CreateArray(int size)
{
    int[] arr = new int[size];

    for (int i = 0; i < size; i++)
        arr[i] = new Random().Next(100, 1000);
    return arr;
}

void CountChet(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 == 0)
            sum += array[i];
    }
    Console.WriteLine($"Сумма элементов: {sum}");
}

Console.WriteLine("введите количество элементов массива");
int[] arr_1 = CreateArray(int.Parse(Console.ReadLine()));
Print(arr_1);
CountChet(arr_1);