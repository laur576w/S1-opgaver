using System.IO;

using (StreamReader sr = new("Values.txt")) {
    string line;
    int sum = 0;
    double i = 0;
    while ((line = sr.ReadLine()) != null) {
        int number = int.Parse(line);
        Console.WriteLine(number);
        sum = sum + number;
        i++;
    }
    Console.WriteLine("det her er sum {0}", sum);
    i = sum / i;
    Console.WriteLine("gennemsnittet er {0}", i);
}

