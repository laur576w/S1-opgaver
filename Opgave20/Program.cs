using System;
﻿using System.IO;
using Opgave20;



//working code
List<int> num = new List<int>();
using (StreamReader sr = new("Values.txt")) {
    
    while (!sr.EndOfStream) {
        string[] n = sr.ReadToEnd().Split('\n');
        
        //write and add them to the line
        foreach (string s in n) { 
            num.Add(int.Parse(s));
            Console.WriteLine(s);
        }
    }
    //adds the numbers up
    Console.WriteLine("Sum: {0}", num.Sum());
    //average
    Console.WriteLine("Average: {0}", num.Average());
}

