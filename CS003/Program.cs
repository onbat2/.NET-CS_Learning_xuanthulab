using System;

//phep tinh so hoc 
// + - * / %
float num1 = 6 / (2 + 3) * 2 + 1;
Console.WriteLine("1, Ket qua num1 la: {0}", num1);

//toan tu gan
// = += -= *= /= %=
int x;
x = 10;
x += 2;
Console.WriteLine("2, Gia tri cua x la: {0}", x);

//tang giam
// x++ ++x x-- --x
int y1 = 10;
int z1 = 2  * y1++;
// tinh gia tri z roi moi thay doi gia tri y
Console.WriteLine("3.1, Gia tri cua y1 la: {0} \n     Gia tri cua z1 la: {1}",
                     y1, z1); 

int y2 = 10;
int z2 = 2  * ++y2;
// thay doi gia tri y, gia tri thay doi ay tinh gia tri moi cho z
Console.WriteLine("3.2, Gia tri cua y2 la: {0} \n     Gia tri cua z2 la: {1}",
                     y2, z2); 