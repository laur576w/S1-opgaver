void SaveRandomNumbersTextFile(string WhereToSaveWithName, int HowManyTimes) {
    HowManyTimes--;
    using (StreamWriter writer = new(WhereToSaveWithName)) {
        Random rng = new Random();
        for (int i = 0; i <= HowManyTimes; i++) {
            writer.WriteLine(rng.Next(1, 7));
        }        
    }
    List<int> numbers = new();
    using (StreamReader reader = new StreamReader(WhereToSaveWithName)) {
        string[] n = reader.ReadToEnd().Split('\n');
        n = n.Where(x => !string.IsNullOrEmpty(x)).ToArray();//removes last empty string so it can be converted to int
        foreach (string s in n) {
            numbers.Add(int.Parse(s));
        }
        
    }
    //to count how many of a number there are
    int total1 = numbers.Count(c => c == 1);
    int total2 = numbers.Count(c => c == 2);
    int total3 = numbers.Count(c => c == 3);
    int total4 = numbers.Count(c => c == 4);
    int total5 = numbers.Count(c => c == 5);
    int total6 = numbers.Count(c => c == 6);

    using (StreamWriter writer = new(WhereToSaveWithName)) {
        numbers.Sort();
        foreach (int i in numbers)
            writer.WriteLine(i);
        //saves how many of each numbers there are in the file
        writer.WriteLine($"There are {total1} of 1\n" +
            $"There are {total2} of 2\n" +
            $"There are {total3} of 3\n" +
            $"There are {total4} of 4\n" +
            $"There are {total5} of 5\n" +
            $"There are {total6} of 6\n");
    }
} 

SaveRandomNumbersTextFile(@"C:\Users\laur576w\Desktop\MyFile.txt", 100);