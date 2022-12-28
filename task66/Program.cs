// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
int left = inputNumber("Введите число 1:");
int right = inputNumber("Введите число 2:");


if (!Merge(left,right))
{
    Swap();
}

Console.WriteLine(Sum(left, right));

bool Merge(int left, int right)
{
    if (right>left)
    return true;
    else return false;
}

void Swap()
{
    int temp = left;
    left = right;
    right = temp;

}

int Sum(int left, int right)
{
    if (right == left-1)
    {
        return 0;
    }
    int result = left + Sum(left + 1, right);
    return result;
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
