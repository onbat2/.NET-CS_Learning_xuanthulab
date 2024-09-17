using System;

int[] numbers = {11, 15, 7, 3, 2, 5, 33, 20, 8};

Console.Write("Cac phan tu cua mang la: ");

for(int i = 0; i < numbers.Length; i++)
{
    if(i == numbers.Length - 1)
    {
        Console.Write(numbers[i]);
        Console.WriteLine();
        break;
    }
    Console.Write(numbers[i] + " ");
}

Console.WriteLine($"So phan tu: {numbers.Length}");
Console.WriteLine($"Chieu: {numbers.Rank}");

Console.WriteLine($"Min: {numbers.Min()}");
Console.WriteLine($"Max: {numbers.Max()}");
Console.WriteLine($"Sum: {numbers.Sum()}");

Array.Sort(numbers);
Console.Write("Cac phan tu sau khi duoc sap xep la: ");

foreach(var item in numbers)
{
    if(item == numbers.Max())
    {
        Console.WriteLine(item);
        break;
    }
    Console.Write(item + " ");
}

Console.WriteLine();
Console.WriteLine("Mang 2 chieu: ");

double[,] arrays = new double[2, 3] {{2, 3, 4.5}, {1, 9, 8}};

int hang = 2;
int cot = 3;

for(int i = 0; i < hang; i++)
{
    for(int j = 0; j < cot; j++)
    {
        Console.Write(arrays[i, j] + " ");
    }
    Console.WriteLine();
}
