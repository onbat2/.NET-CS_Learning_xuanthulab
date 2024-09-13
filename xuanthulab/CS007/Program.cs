using System;

Console.WriteLine("1, while + break");
int a = 0;
while (a < 1000)
{
    Console.WriteLine($"a = {a}");
    a++;
    if(a == 6) break;
}

Console.WriteLine();
Console.WriteLine("2, for + continue");
for(int i = 10; i <= 20; i++)
{
    if(i % 2 != 0) continue;

    Console.WriteLine($"b = {i}");
}

Console.WriteLine();
Console.WriteLine("3, do while");
int c = 3000;
do
{
    Console.WriteLine($"c = {c}");
    c++;
}while(c < 10);