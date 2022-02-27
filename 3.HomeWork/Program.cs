// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N (например, 8 -> 2, 4, 6, 8).
// Решение домашнего задания № 4.

Console.Clear();

Console.Write("Введите число: ");
string strValue = Console.ReadLine();
int Value = int.Parse(strValue);
int index = 1;

Console.WriteLine("------------------");
while (index <= Value)
{
    if (index%2 == 0)
    {
        Console.Write($"{index}, ");
    }
    index++;
}