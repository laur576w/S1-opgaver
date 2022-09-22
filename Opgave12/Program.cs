//opgave 12.1
int i;

for (i = 1; i <= 10; i++) { 
    Console.WriteLine(i);
}

for (i = 10; i > 0; i--) {
    Console.WriteLine(i);
}

for (i = 2; i < 21; i = i + 2) {
    Console.WriteLine(i);
}

for (i = 21; i > 0; i = i - 2) {
    Console.WriteLine(i);
}

Console.WriteLine();


//opgave 12.2
Console.WriteLine("Hviken tabel ville du have?");
int number = int.Parse(Console.ReadLine());

for (i = 1; i <= 10; i++) { 
    Console.WriteLine(number*i);
}

Console.WriteLine();


//opgave 12.3
int x;

for (x = 1; x <= 10; x++) {
    for (i = x; i <= x * 10; i = i + x) {
        Console.Write(i.ToString().PadLeft(5));
    }
    Console.WriteLine();
}

Console.WriteLine();


//opgave 12.4
Random rng = new Random();

while (x != 6) {
    Console.WriteLine("Tallet er {0}", x = rng.Next(1, 7));
}
Console.WriteLine("Horray");
