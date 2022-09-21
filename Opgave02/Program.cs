//opgave 2.1
string first_name = "Karsten";
string last_name = "Hansen";
int age = 35;

Console.WriteLine($"Fornavn: {first_name}.");
Console.WriteLine($"Efternavn: {last_name}.");
Console.WriteLine($"Alder: {age}.");
Console.WriteLine();

//opgave 2.2
string title = "Lord of The Rings - The Two Towers";
long isbn = 9780007117116;
int sides = 400;
double price = 249.99;

Console.WriteLine($"Titel: {title}.");
Console.WriteLine($"ISBN nummer: {isbn}.");
Console.WriteLine($"Antal sider: {sides}.");
Console.WriteLine($"Pris: {price}kr.");
Console.WriteLine();

//opgave 2.3
int int_min = -2147483648;
int int_max = 2147483647;
uint uint_min = 0;
uint uint_max = 4294967295;
long long_min = -9223372036854775808;
long long_max = long.MaxValue;
byte byte_min = byte.MinValue;
byte byte_max = byte.MaxValue;
short short_min = short.MinValue;
short short_max = short.MaxValue;

Console.WriteLine($"Min-Max int: {int_min} .. {int_max}.");
Console.WriteLine($"Min-Max uint: {uint_min} .. {uint_max}.");
Console.WriteLine($"Min-Max long: {long_min} .. {long_max}");
Console.WriteLine($"Min-Max byte: {byte_min} .. {byte_max}");
Console.WriteLine($"Min-Max short: {short_min} .. {short_max}");
