// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int size = ReadInt("Введите размер массива: ");
int [] numbers = new int[size];

ArrayRandomNumbers(numbers);
PrintArray(numbers);
int result = 0;

for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] % 2 == 0)
    {
        result++;
    }
}
if (result % 10 == 1)
{
    Console.WriteLine($"-> {result}");
}
if (result % 10 == 2 || result % 10 == 3 || result % 10 == 4)
{
    Console.WriteLine($"-> {result}");
}
else 

    Console.WriteLine($" -> {result}");

void ArrayRandomNumbers(int [] array) 
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(99, 999);
    }
}

void PrintArray(int[] array) 
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

int ReadInt(string message) 
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}