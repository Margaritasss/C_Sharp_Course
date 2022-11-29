// Задача 3:
// Напишите программу, которая выводит третью цифру
// заданного числа или сообщает, что третьей цифры нет.

string answer (int RND)
{
    if (RND >= 100)
    {
        while (RND >= 1000)
        {
            RND = RND / 10;
        }
        return "Третья цифра числа это " + RND % 10;
    }
    else
    {
        return ("У числа нет третьей цифры");
    }
}

Console.WriteLine("Введите число");
int X = int.Parse(Console.ReadLine());
Console.WriteLine(answer(X));