using System;
using System.IO;
using Opgave20;



static List<int> GetNumbersFromFile(string path) {
    int i = 0;
    List<int> numbers = new();
    StreamReader sr = new(path);
    string[] n = sr.ReadToEnd().Split('\n');
    sr.Close();
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
