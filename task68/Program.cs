//  Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
int n = inputNumber("Введите целое неотрицательное число 1:");
int n2 = inputNumber("Введите целое неотрицательное число 2:");
Console.WriteLine(accermanFunction(n, n2));

int accermanFunction(int n, int n2)
{
    if (n == 0)
    {
        return n2 + 1;
    }
    else if ((n != 0) && (n2 == 0))
    {
        return accermanFunction(n - 1, 1);
    }
    else
    {
        return accermanFunction(n - 1, accermanFunction(n, n2 - 1));
    }

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