Console.WriteLine("1");
//Lenh, cau truc re nhanh
/*
[8 - 10]: Gioi
[6.5 - 8]: Kha
[5.0 - 6.5]: Trung Binh
[0 - 5.0]: Yeu
*/

float score;
Console.Write("Hay nhap diem trung binh: ");
score = float.Parse(Console.ReadLine());

if(score < 5.0)
{
    Console.WriteLine("Hoc luc Yeu");
}
else if(score < 6.5)
{
    Console.WriteLine("Hoc luc Trung Binh");
}
else if(score < 8)
{
    Console.WriteLine("Hoc luc Kha");
}
else if(score <= 10)
{
    Console.WriteLine("Hoc luc Tot");
}
else
{
    Console.WriteLine("Nhap lai diem [0, 10]");
}
Console.WriteLine("");

Console.WriteLine("2");
// Toan tu 3 ngoi
// (dieu_kien) ? bieuthuc1 : bieuthuc2;

float a, b;
Console.Write("Nhap so a: ");
a = float.Parse(Console.ReadLine());
Console.Write("Nhap so b: ");
b = float.Parse(Console.ReadLine());

float max;
max = (a > b) ? a : b;

Console.WriteLine("So lon nhat la: {0}", max);