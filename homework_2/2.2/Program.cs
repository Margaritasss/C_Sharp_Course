// Задача 2:
// Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого числа.

int answer (int RND)
{
    Console.WriteLine(RND);
    return ((RND / 100) * 10 + (RND % 100) % 10);
}

Console.WriteLine("Введите число");
int X = new Random().Next(100, 1000); //int.Parse(Console.ReadLine());
Console.WriteLine("Число без второй цифры " + answer(X));