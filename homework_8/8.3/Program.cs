// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

void Print(int[,] arr)
{
    int row_size = arr.GetLength(0);
    int column_size = arr.GetLength(1);

    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; j < column_size; j++)
            Console.Write($" {arr[i, j],4} ");
        Console.WriteLine();
    }
    Console.WriteLine();

}

int[,] MassNums(int row, int column, int from, int to)
{
    int[,] arr = new int[row, column];

    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            arr[i, j] = new Random().Next(from, to);

    return arr;
}

void Composition(int[,] arr1, int[,] arr2, int[,] arr3)
{
    for (int i = 0; i < arr1.GetLength(0); i++)
    {
        for (int j = 0; j < arr1.GetLength(1); j++)
        {
            for (int z = 0; z < arr1.GetLength(0); z++)
            {
                arr3[i, j] = arr3[i, j] + (arr1[i, z] * arr2[z, j]);
            }
        }
    }
}

Console.Write("Введите размер массива: ");
int size = int.Parse(Console.ReadLine());

int[,] array_1 = MassNums(size, size,
                        int.Parse(Console.ReadLine()),
                        int.Parse(Console.ReadLine()));
int[,] array_2 = MassNums(size, size,
                        int.Parse(Console.ReadLine()),
                        int.Parse(Console.ReadLine()));
int[,] array_3 = new int[size, size];                        
Print(array_1);
Print(array_2);
Composition(array_1, array_2, array_3);
Print(array_3);
