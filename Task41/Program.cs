﻿// Задача 41: Пользователь вводит с клавиатуры M чисел в одну линию 
// (не используем Enter). Числа разделены пробелами. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0 7 8 -2 -2 -> 2
//1 -7 567 89 223-> 4


Console.Write("Введите числа через пробел: ");
int[] array = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int count = array.Count(x => x > 0);
Console.WriteLine($"Кол-во элементов > 0: {count}");