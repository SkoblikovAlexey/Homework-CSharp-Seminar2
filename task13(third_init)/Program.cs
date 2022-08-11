// Задача 13: Напишите программу, которая выводит третью цифру 
// заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

while (true)
{
    Console.WriteLine("Введите число.");
    int number = Convert.ToInt32(Console.ReadLine());
    string str = Convert.ToString(number);
    if (str.Length > 2)
    {
        Console.WriteLine(str[2]);
    }
    else
    {
        Console.WriteLine("У введенного числа нет третьей цифры.");
    }
    Console.WriteLine("Для завершения введите end, для продолжения - любой символ");
    string a = Console.ReadLine();
    if (a == "end")
    {
        break;
    }
}