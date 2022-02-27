// пример из семинара 1. Напишите программу, которая на вход принимает 2 числа и проверяет, является ли 1 число квадратом 2 числа.
Console.Write("Введите число 1: ");
string strValue1 = Console.ReadLine();
int Value1 = int.Parse(strValue1);

Console.Write("Введите число 2: ");
string strValue2 = Console.ReadLine();
int Value2 = int.Parse(strValue2);

int rezult = Value1 * Value1;

if (rezult == Value2)
{
    Console.WriteLine($"Число {Value1} является квадратом числа {Value2}");
}

Console.WriteLine($"Число {Value1} не является квадратом числа {Value2}");