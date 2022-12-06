void Chet(int N)
{
    int i = 0;
    double pere;
    while (i < N)
    {
        i += 1;
        pere = Math.Pow(i,2);
        Console.Write($"{pere},");
    }
}
Console.WriteLine("введите ч");
int chislo = int.Parse(Console.ReadLine());
Chet(chislo);