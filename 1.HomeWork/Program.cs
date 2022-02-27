// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее. (Пример: a = 5; b = 7 ->  max = 7)

// Решение домашнего задания №1 и 2.
Console.Clear();

Console.Write("Введите количество генерируемых чисел: ");
string strGenNum = Console.ReadLine();
int genNum = int.Parse(strGenNum);

Console.Write("Введите максимальное число: ");  //не догадался, как задать количество цифр в числе? (например, при вводе 3 - выдаются числа из 3х разрядов 345, 654)
string strValue = Console.ReadLine();
int Value = int.Parse(strValue);

int maxNumber = 0;
int minNumber = Value;
int index = 0;

Console.WriteLine("--------------------------");
Console.Write("Сгенерированные числа: ");
while (index < genNum)
{ 
    int rangeNumbers = new Random().Next(0, Value);
    Console.Write($"{rangeNumbers}, ");
    if (rangeNumbers > maxNumber)
    {
        maxNumber = rangeNumbers;
    }
    else if (minNumber > rangeNumbers)
    {
        minNumber = rangeNumbers;
    }
    index++;
}
Console.WriteLine(" ");
Console.WriteLine($"Максимальное число - {maxNumber}");
Console.WriteLine($"Минимальное число - {minNumber}");