// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите первое натуральное число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе натуральное число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

if (firstNumber < 1)
{
    Console.WriteLine($"{firstNumber} - Это не натуральное число");
    return;
}
if (secondNumber < 1)
{
    Console.WriteLine($"{secondNumber} - Это не натуральное число");
    return;
}

int sumBetweenNumbers = SumBetweenNum(firstNumber, secondNumber);
Console.WriteLine(sumBetweenNumbers);

int SumBetweenNum(int firstNum, int secondNum)
{
    
    if (secondNum == firstNum) return firstNum;
    if (firstNum > secondNum)
    {
        firstNum += SumBetweenNum(firstNum - 1, secondNum);
    }
    else if (firstNum < secondNum)
    {
        firstNum += SumBetweenNum(firstNum + 1, secondNum);
    }
    return firstNum;
}