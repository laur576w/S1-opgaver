
void SayHello( string name ) {
    Console.WriteLine("Hello " + name);
}
void SayGoodbye(string name) {
    Console.WriteLine("Goodbye " + name);
}

SayHello("Daniel");
SayGoodbye("Karsten");

void DoubleUp (int number) {
    Console.WriteLine("Double up {0}", number * 2);
}
DoubleUp(9);

void add(int a, int b) {
    Console.WriteLine($"Det gir: {a + b}");
}
add(1,2);

void FindGreatestNumber(int a, int b) {
    if (a > b)
        Console.WriteLine(a);
    else
        Console.WriteLine(b);
}
FindGreatestNumber(5, 7);



void PrintArray(string[] names) {
    foreach (string name in names) {
        Console.WriteLine(name);
    }
   
}
string[] names = { "Ib", "Bo" };


PrintArray(names);
