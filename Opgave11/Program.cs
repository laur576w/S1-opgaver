﻿//opgave 11.1
int x = 1;

while (x <= 10) {
    Console.WriteLine(x);
    x++;
}

while (x >= 1) {
    Console.WriteLine(x);
    x--;
}

Console.WriteLine("Alle lige tal mellem 1 - 20");
while (x <= 20) {
    if (x % 2 == 0) {
        Console.WriteLine(x);
        x++;
    }
    else
        x++;
}

Console.WriteLine("Alle ulige tal mellem 20 - 1");
while (x >= 1) {
    if (x % 2 == 1) {
        Console.WriteLine(x);
        x--;
    }
    else
        x--;
}

Console.WriteLine();

//opgave 11.2
x = 1;
Console.Write("Indskriv tabellen du ville have frem ");
int number = int.Parse(Console.ReadLine());

while (x <= 10) {
    int result = number * x;
    Console.WriteLine(result);
    x++;
}

Console.WriteLine();


//opgave 11.3 & 11.4

string slut = "";
while (slut.ToLower() != "exit") {
    Console.Write("Skriv et tal mellem 1 og 10: ");
    x = int.Parse(Console.ReadLine());

    while (x < 1 || x > 10) {
        Console.Write("Indtast nu et tal mellem 1 og 10: ");
        x = int.Parse(Console.ReadLine());
    }
    Console.WriteLine("Godt gjort måske er du klogere end en i første klasse.");

    Console.Write("Vil du forsætte? \n" +
        "Ellers skriv 'exit' ");
    slut = Console.ReadLine(); 
}
