// Напишите программу,которая на вход принимает два числа и проверяет,
// является ли первое число квадратом второго.

// Запрос числа от пользователя.

Console.WriteLine("Введите первое число a");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число B");
int numberB = Convert.ToInt32(Console.ReadLine());

if (numberA == numberB * numberB)
{
    Console.WriteLine("Число a является квадратом числа b");
}
else
{
    Console.WriteLine("Число a не является квадратом числа b");
 }