// Задача 10: Напишите программу, которая принимает на вход трёхзначное число
//  и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

bool calculation = true;
while (calculation)
{
    Console.WriteLine("Введите трёхзначное число.");
    int number = Convert.ToInt32(Console.ReadLine());
    int temp = number / 10;
    int result = temp % 10;
    Console.WriteLine(result);
    Console.WriteLine("Для завершения введите end, для продолжения - любой символ");
    string a = Console.ReadLine();
    if (a == "end")
    {
        calculation = false;
    }
}