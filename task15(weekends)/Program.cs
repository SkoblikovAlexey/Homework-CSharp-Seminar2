// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет


while (true)
{
    bool[] weekends = { false, false, false, false, false, true, true };
    Console.WriteLine("Введите номер дня недели (от 1 до 7 включительно)");
    int number = Convert.ToInt32(Console.ReadLine());
    bool check = weekends[number - 1];
    if (check == false)
    {
        Console.WriteLine("День под номером " + number + " - будний.");
    }
    else
    {
        Console.WriteLine("День под номером " + number + " - выходной.");
    }
    Console.WriteLine("Для завершения введите end, для продолжения - любой символ");
    string a = Console.ReadLine();
    if (a == "end")
    {
        break;
    }
}