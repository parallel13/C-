﻿// программа, которая выдает название дня недели по введенному числу
Console.WriteLine("Введите номер");
string num = Console.ReadLine();

if (num == "1")
{
    Console.WriteLine("Понедельник");
}
else if (num == "2")
{
    Console.WriteLine("Вторник");
}
else if (num == "3")
{
    Console.WriteLine("среда");
}
else if (num == "4")
{
    Console.WriteLine("Четверг");
}

else if (num == "5")
{
    Console.WriteLine("Пятница");
}

else if (num == "6")
{
    Console.WriteLine("Суббота");
}

else if (num == "7")
{
    Console.WriteLine("Воскресенье");
}
else
{
    Console.WriteLine("Нет такого дня недели");
}




