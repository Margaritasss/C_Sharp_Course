// Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

void answer(int N)
{
   int i = 1;
   double result;
   while (i <= N )
   {
        result = Math.Pow(i,3);
        if (i+1 > N) Console.Write($"{result}");
        else Console.Write($"{result}, ");
        i += 1;
   }
    
   
}
Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());
answer(num);