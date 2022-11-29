// Задача 1:
// Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа.

int answer (int RND)
{
    return (RND / 10) % 10;
}

Console.WriteLine("Введите число");
int X = int.Parse(Console.ReadLine());
Console.WriteLine("Вторая цифра числа это " + answer(X));