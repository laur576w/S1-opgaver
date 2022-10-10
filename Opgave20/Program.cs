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



