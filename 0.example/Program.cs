// пример из семинара 0. Напишите программу, которая на вход принимает число и выдет квадрат этого числа. 4-16, -9-81 и т.д.

Console.Write("Введите число: ");
string strValue = Console.ReadLine(); //ввод строки
int value = int.Parse(strValue);    //преобразуем строку в целое число

int rezult = value * value;         //вычисление квадрата
Console.Write($"Квадрат числа {value} равен {rezult}");