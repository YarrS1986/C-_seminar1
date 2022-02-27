// пример из семинара 1. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" 
// 2 -> " -2, -1, 0, 1, 2"

Console.Write("Введите число: ");
string strValue = Console.ReadLine();
int Value = int.Parse(strValue);
int minusValue = 0 - Value;

while (minusValue <= Value)
{
    Console.WriteLine(minusValue);
    minusValue++;
}