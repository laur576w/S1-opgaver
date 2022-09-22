int i;
//opgave 13.1
int[] ages = new int[5] {25,28,15,35,14};

for (i = 0; i < ages.Length; i++)
    Console.WriteLine("alder: {0}", ages[i]);

Console.WriteLine();


//opgave 13.2
string[] names = new string[4] { "Hans", "Anton", "Betinna", "Jesper" };
for (i = 0; i < names.Length; i++)
    Console.WriteLine(names[i]);

names[^1] = "Kong Jesper";

for (i = 0; i < names.Length; i++) 
    Console.WriteLine(names[i]);

Console.WriteLine();


//opgave 13.3 
int[] numbers = new int[] { 7, 79, 95, 73, 78, 18, 76, 80, 60, 21 };
for (i = 0; i < numbers.Length; i++)
    Console.WriteLine(numbers[i]);

Array.Sort(numbers);

for (i = 0; i < numbers.Length; i++)
    Console.WriteLine(numbers[i]);

Console.WriteLine();


//opgave 13.4
Console.WriteLine("sidste opgave");
for (i = 0; i < numbers.Length; i++)
    numbers[i] = numbers[i] + 5;