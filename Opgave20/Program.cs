using Opgave20;
using Person;

static List<int> GetNumbersFromFile(string path) {
    List<int> numbers = new();
    StreamReader sr = new(path);
    string[] n = sr.ReadToEnd().Split('\n');
    foreach (string s in n) {
        numbers.Add(int.Parse(s));
    }

    return numbers;
}

//adds the numbers up
Console.WriteLine("Sum: {0}", GetNumbersFromFile("Values.txt").Sum());
//average
Console.WriteLine("Average: {0}\n", GetNumbersFromFile("Values.txt").Average());


static List<int> getVolumeFromFile(string path) {
    List<int> volumes = new();
    List<Box> boxes = new List<Box>();
    StreamReader sr = new(path);
    string[] splitstring = sr.ReadToEnd().Split(',', '\n');
    for (int i = 0; i < splitstring.Length; i += 3) {
        int NumHeight = int.Parse(splitstring[i]);
        int NumLength = int.Parse(splitstring[i + 1]);
        int NumWidth = int.Parse(splitstring[i + 2]);
        Box box = new(NumHeight, NumLength, NumWidth);
        boxes.Add(box);
    }
    for (int i = 0; i < boxes.Count; i++) {
        volumes.Add(boxes[i].CalcVolume());  
    }
    return volumes;
}

Console.WriteLine("Average volume {0}", getVolumeFromFile("Boxes.txt").Average());
Console.WriteLine("Min volume {0}", getVolumeFromFile("Boxes.txt").Min());
Console.WriteLine("Max volume {0}", getVolumeFromFile("Boxes.txt").Max());

int a = 0;
foreach (int i in getVolumeFromFile("Boxes.txt")) {
    
    a++;
    Console.WriteLine("({0})Box: {1}", a, i);
    
}


Console.WriteLine();

List<Persons> persons = new();
StreamReader reader = new("Persons.txt"); 
string[] splitstring = reader.ReadToEnd().Split(',', '\n');
for (int i = 0; i < splitstring.Length; i += 3) {
    Persons person = new(splitstring[i], splitstring[i + 1], int.Parse(splitstring[i + 2]));
    persons.Add(person);
}
Console.WriteLine("oldest " + Persons.FindOldestPerson(persons));
Console.WriteLine("youngest " + Persons.FindYoungestPerson(persons));
Console.WriteLine("longest firstname " + Persons.LongestFirstName(persons));
Console.WriteLine("shortest firstname " + Persons.ShortestFirstName(persons));
Console.WriteLine("longest fullname " + Persons.LongestName(persons));
Console.WriteLine("Shortest fullname" + Persons.ShortestName(persons));

