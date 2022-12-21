// Задайте значения M и N. Напишите программу, которая 
// найдёт сумму натуральных элементов в промежутке от M до N.

int Summ(int m, int n)
{
    int result = m;
    if (m == n)
        return 0;
    else
    {
        m++;
        result = m + Summ(m, n);
        return result;
    }
}

Console.Write("Введите первое число: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine($"Сумма натуральных элементов в промежутке от первого до второго числа = {Summ(m-1, n)} ");
