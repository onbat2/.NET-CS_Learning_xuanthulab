// toan tu so sanh
// == > < >= <= !=

bool result;

int a = 5; 
int b = 6;
result = a == b;

Console.WriteLine("1");
Console.WriteLine("a == b ===> {0}", result);
Console.WriteLine($"a != b ===> {a != b}");
Console.WriteLine("");

// toan tu logic
// && || !

bool m = false;
bool n = true;
bool Im_True = true;

bool result1 = m && n;

Console.WriteLine("2");
Console.WriteLine("m && n ===> {0}", result1);
Console.WriteLine($"m || n ===> {m || n}");
Console.WriteLine($"!Im_True ===> {!Im_True}");