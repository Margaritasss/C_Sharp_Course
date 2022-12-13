//Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.

string[] arrfunc(int size)
{
    string[] arr = new string[size];

    for (int i = 0; i < Convert.ToInt16(size); i++)
        arr[i] = Console.ReadLine();
    return arr;
}

void Answer(string[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {   
        if(Convert.ToInt16(array[i]) > 0)
            sum++;
    }
    Console.WriteLine($"Чисел больше нуля: {sum}");
}

Console.Write("Введите количество элементов: ");
string[] arr_1 = arrfunc(int.Parse(Console.ReadLine()));
Answer(arr_1);