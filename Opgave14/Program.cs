int i;
//opgave 14.1 & 14.2
List<int> ages = new List<int>() { 5, 17, 20, 40, 51};

List<string> names = new List<string>() { "Jens", "Karl", "Johannes", "Anton", "Nicklas" };

List<double> percentages = new List<double>() { 0.75, 0.23, 0.86, 0.17 };

List<bool> are_married = new List<bool>() { true, false, false, true, true };


//opgave 14.3
for (i = 0; i < ages.Count; i++)
    Console.WriteLine(ages[i]);
for (i = 0; i < names.Count; i++)
    Console.WriteLine(names[i]);

foreach (double percentage in percentages)
    Console.WriteLine(percentage);
foreach (bool is_married in are_married)
    Console.WriteLine(is_married);

Console.WriteLine();


//opgave 14.4
List<string> names1 = new List<string>() { "Hans", "Kristian", "Jens", "Karsten", "Ib" };

foreach (string name in names1)
    Console.WriteLine(name);

names1.Insert(3, "Anders");
names1.Insert(2, "Lars");

foreach (string name in names1)
    Console.WriteLine(name);

Console.WriteLine();


//opgave 14.5
List<int> ages1 = new List<int>() { 13, 14, 13, 15, 13, 14, 14, 15 };
foreach (int age in ages1)
    Console.WriteLine(age);

Console.WriteLine(); //air

ages1.Remove(13);
ages1.Remove(15); //current line 14, 13, 13, 14, 14, 15
foreach (int age in ages1)
    Console.WriteLine(age);

Console.WriteLine(); //air

ages1.RemoveAt(3); //current line 14, 13, 13, 14 ,15
foreach (int age in ages1)
    Console.WriteLine(age);
