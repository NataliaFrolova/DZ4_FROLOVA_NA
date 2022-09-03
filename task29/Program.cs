// Задача 29: Напишите программу, которая задаёт массив из введенного числа и выводит их на экран.
// пользователь вводит число элементов в массиве и минимальное, 
// и максимальное значение . надо заполнить массив рандоными данными от минимального до максимального значение.
// И важное уточнениее , делать все в методе который возвращает массив
// 5, 1, 20 -> [1, 2, 5, 7, 19]
// 3, 1, 33 -> [6, 1, 33]

Console.WriteLine("Enter array size: ");
int arraySize = int.Parse(Console.ReadLine());

Console.WriteLine("Enter min: ");
int min = int.Parse(Console.ReadLine());

Console.WriteLine("Enter max: ");
int max = int.Parse(Console.ReadLine());

int[] array = new int[arraySize];

int[] EnterRandomArray()
{
    for (int i = 0; i < arraySize; i++)
    {
        array[i] = new Random().Next(min, max);
    }

    Console.WriteLine(String.Join(", ", array));
    return array;
}
EnterRandomArray();

