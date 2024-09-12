using System;

float a, b;
string sinput;

Console.WriteLine("Hay nhap so a: ");
sinput = Console.ReadLine();
a = float.Parse(sinput);

Console.WriteLine("Hay nhap so b: ");
sinput = Console.ReadLine();
b = Convert.ToSingle(sinput);

Console.WriteLine("So a = {0}, so b = {1}", a, b);