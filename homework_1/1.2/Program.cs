// Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Введите первое число");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число");
int b = int.Parse(Console.ReadLine());

Console.WriteLine("Введите третье число");
int c = int.Parse(Console.ReadLine());
int max = c;

if (a > max) max = a;
if (b > max) max = b;
Console.WriteLine(a + " " +  b + " " + c + " -> " + max);