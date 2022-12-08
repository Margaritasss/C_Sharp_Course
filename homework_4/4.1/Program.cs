// Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.

string answer(int A, int B)
{
    int x = 1;
    
    for (int i = 1; i <= B; i++)
    {
        x = x * A;
    }
    return (A + ", " + B + " -> " + x);
}

Console.WriteLine("Введите число A: ");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int num2 = int.Parse(Console.ReadLine());

Console.WriteLine(answer(num1, num2));