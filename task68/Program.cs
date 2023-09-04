// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// n = 2, m = 3 -> A(n,m) = 9
// n = 3, m = 2 -> A(n,m) = 29
Console.WriteLine("Введите два числа для вычисления функции Акк");
Console.Write("Введите  число n: ");
int numberN = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите  число m: ");
int numberM = Convert.ToInt32(Console.ReadLine());

if (numberM < 0 || numberN <0)
{
    Console.WriteLine("Некорректный ввод,вводите числа от 0 и больше");
    return;
}

int FunctionAccerman(int numN, int numM)
{
    if (numN == 0)
        return numM + 1;
    else if (numM == 0 && numN != 0)
        return FunctionAccerman(numN - 1, 1);
    else
        return FunctionAccerman(numN - 1, FunctionAccerman(numN, numM - 1));
}

int functinAccerman= FunctionAccerman(numberN, numberM);
Console.WriteLine(functinAccerman);