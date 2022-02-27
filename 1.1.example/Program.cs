// пример из семинара 1. Напишите программу, которая будет выдавать название дня недели по заданному числу. 3- среда, 5 - пятница и т.д.

Console.Write("Введите число от 1 до 7: ");
string strValue = Console.ReadLine();
int Value = int.Parse(strValue);

if (Value == 1)
{
    Console.WriteLine($"{Value} - Понедельник");
}

else if (Value == 2)
{
    Console.WriteLine($"{Value} - Вторник");
}

else if (Value == 3)
{
    Console.WriteLine($"{Value} - Среда");
}

else if (Value == 4)
{
    Console.WriteLine($"{Value} - Четверг");
}

else if (Value == 5)
{
    Console.WriteLine($"{Value} - Пятница");
}

else if (Value == 6)
{
    Console.WriteLine($"{Value} - Субоота");
}

else if (Value == 7)
{
    Console.WriteLine($"{Value} - Воскресенье");
}

else
{
    Console.WriteLine("Неверное число");
}