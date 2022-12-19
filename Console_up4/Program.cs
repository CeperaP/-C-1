// Задача 7. Напишите программу,которая на вход принимает трехзначное число
// и на выходе показывает последнюю цифру этого числа.

Console.WriteLine("Введите трехзначное число:");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(number%10);