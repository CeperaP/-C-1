﻿// Напишите программу, которая на вход принимает  целое число и выдает его квадрат.


// Запрос числа от пользователя
Console.Write("Введите целое число");
int number = Convert.ToInt32(Console.ReadLine());
// Квадрат введенного числа
int result = number * number;


// Вывод результата
Console.WriteLine($"Квадрат числа ={result}");
