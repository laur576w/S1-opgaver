int i;

//opgave 2.1
for (i = 1; i <= 10; i++) 
    Console.WriteLine(i);
    Console.WriteLine();

i = 1;

while (i <= 10) {
    Console.WriteLine(i);
    i++;
}

Console.WriteLine();


//opgave 2.2
for (i = 1; i <= 25; i = i + 2) 
    Console.WriteLine(i);

Console.WriteLine();


//opgave 2.3
Random rng = new Random();
while (i != 6)
    Console.WriteLine(i = rng.Next(1, 7));

Console.WriteLine("ramt");

for (i = 1; i != 6; i = rng.Next(1, 7)) {
    Console.WriteLine(i);
}

Console.WriteLine("ramt\n");


//opgave 2.4
i = 1;
while (i <= 25) {
    if (i % 2 == 0) {
        Console.WriteLine(i);
        i++;
    }
    else
        i++;
}

for (i = 1; i <= 25; i++) {
    if (i % 2 == 0) {
        Console.WriteLine(i);
    }
}
Console.WriteLine();


//opgave 2.5
for (i = 0; i < 25; i++) {
    if (i % 3 == 0) {
        Console.WriteLine(i);
    }
}
