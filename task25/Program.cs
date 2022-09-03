// Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3?)
// 2, 4 -> 16

Console.WriteLine("Enter numberA: ");
int numberA = int.Parse(Console.ReadLine());
Console.WriteLine("Enter numberB: ");
int numberB = int.Parse(Console.ReadLine());

int result = numberA;

for (int i = 1; i < numberB; i++)
{
    result *= numberA;
}

Console.WriteLine($"{numberA}, {numberB} -> {result}");


