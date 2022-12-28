//  Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
int n = inputNumber("Введите число:");
IncreaseNumber(n);
void IncreaseNumber(int n)
{

    if (n == 0)
    {
        return;
    }
    IncreaseNumber(n - 1);

    Console.Write($"{n}; ");
}
int inputNumber(string str)
{
    int number;
    string text;

    while (true)
    {
        System.Console.WriteLine(str);
        text = Console.ReadLine();
        if (int.TryParse(text, out number))
        {
            break;
        }
        System.Console.WriteLine("Не удалось распознать число, попробуйте еще раз.");
    }
    return number;
}