//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

Console.WriteLine("Введите число A: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());
int step = numberA;
for (int i = 1; i < numberB; i++)
{
step = step * numberA;
}
Console.WriteLine("A в степени B равно: " + step);
