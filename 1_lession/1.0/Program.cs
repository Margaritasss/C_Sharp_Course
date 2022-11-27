Console.WriteLine("Введите число, которое хотите возвести в квадрат");
double numberA = Convert.ToDouble(Console.ReadLine());
double X = 1;
string str1 = "";

X = numberA * numberA;

str1 = numberA + " -> " + X;

Console.WriteLine(str1);