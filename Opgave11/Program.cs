//opgave 11.1
int x = 1;


//runs while x is smaller than 10
while (x <= 10) {
    Console.WriteLine(x);
    x++;
}
Console.WriteLine();

//runs while x is bigger than 1
while (x >= 1) {
    Console.WriteLine(x);
    x--;
}
Console.WriteLine();

//even numbers from 1 - 20
Console.WriteLine("Alle lige tal mellem 1 - 20");
while (x <= 20) {
    if (x % 2 == 0) {
        Console.WriteLine(x);
        x++;
    }
    else
        x++;
}
Console.WriteLine();

//odd numbers from 20 - 1
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

//outputs the numeric table of the one you wanted if it's below or is 10
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
    int SadFace = 0;
    while (x < 1 || x > 10) {
        Console.Write("Indtast nu et tal mellem 1 og 10 du er jo ikke så dum: ");
        x = int.Parse(Console.ReadLine());
        SadFace++;
        if (SadFace > 10) 
            Console.WriteLine("Skriv en af følgende:\n" +
                "1, 2, 3, 4, 5, 6, 7, 8, 9, 10.");
        
    }
    Console.WriteLine("Godt gjort måske er du klogere end en i første klasse.");

    Console.Write("Vil du forsætte? \n" +
        "Ellers skriv 'exit' ");
    slut = Console.ReadLine(); 
}
