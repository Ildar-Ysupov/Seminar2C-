﻿// Задача 13: Напишите программу, которая выводит 
// третью цифру заданного числа или сообщает, что третьей 
// цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int number = Convert.ToInt32(Console.ReadLine());

if (number > 99)
{
    string strNumber = number.ToString();
    Console.WriteLine(strNumber[2]);
}
else Console.WriteLine(" Нет третьей цифры ");
