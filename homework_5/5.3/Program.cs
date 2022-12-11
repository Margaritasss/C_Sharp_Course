// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

void Print(double[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
        Console.Write($"{arr[i]} ");
    Console.WriteLine();
}

double[] CreateArray(int size)
{
    double[] arr = new double[size];

    for (int i = 0; i < size; i++)
        arr[i] = Convert.ToDouble(new Random().Next(100, 10000)) / 100;
    return arr;
}

void answer(double[] array)
{
    double max = array[0];
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min) min = array[i];
        if (array[i] > max) max = array[i];
    }
    Console.WriteLine($"максимальный элемент: {max}");
    Console.WriteLine($"минимальный элемент: {min}");
    Console.WriteLine($"разность между максимальным и минимальным элементом: {Math.Round(max - min, 2)}");
}

Console.WriteLine("введите количество элементов массива");
double[] arr_1 = CreateArray(int.Parse(Console.ReadLine()));
Print(arr_1);
answer(arr_1);