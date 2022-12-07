// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран

void answer(int A)
{
    string result = "";
    int[] massiv = new int[A];
    for (int i = 0; i < massiv.Length; i++)
    {
        massiv[i] = new Random().Next(1, 1000);
        if (i == 0) result = "" + massiv[i];   
        else result = result + " " + massiv[i];
    }
    Console.Write("[" + result + "]");
}

Console.Write("Введите число элементов массива: ");
int x = int.Parse(Console.ReadLine());
answer(x);