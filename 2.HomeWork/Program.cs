// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.Clear();

Console.Write("Введите число: ");
string strNumber = Console.ReadLine();
int Number = int.Parse(strNumber);

if (Number%2 == 0)
{
    Console.WriteLine($"Число {Number} - четное");
}
else
Console.WriteLine($"Число {Number} - нечетное");