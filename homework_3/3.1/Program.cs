// Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.

string answer(int N)
{
    int N2 = N;
    int num = 0;
    int reverse = 0;
    while (N > 0)
    {
        num = N % 10;
        reverse = reverse * 10 + num;
        N = N / 10;
    }
    if (N2 == reverse)
        return "Да";
    else
        return "Нет";
}

Console.WriteLine("Введите пятизначное число: ");
int X = int.Parse(Console.ReadLine());
Console.WriteLine(answer(X));