// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

string answer(int num)
{
    int sum = 0;
    int x = num;
    int new_num = 0;

    while (num > 0)
    {
        new_num = num % 10;
        sum = sum + new_num;
        num = num / 10;
    }
    return (x + " -> " + sum);
}

Console.WriteLine("Введите число: ");
int A = int.Parse(Console.ReadLine());

Console.WriteLine(answer(A));