using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persons {
    internal class Persons {
        public List<string> FirstNames { get; set; }
        public List<string> LastNames { get; set; }
        public List<int> Ages { get; set; }
        public Persons(string path) {
            StreamReader sr = new StreamReader(path);
            List<string> firstnames = new();
            List<string> lastnames = new();
            List<int> ages = new();
            string[] splitstring = sr.ReadToEnd().Split(',', '\n');
            for (int i = 0; i < splitstring.Length; i += 3) {
                firstnames.Add(splitstring[i]);
                lastnames.Add(splitstring[i + 1]);
                ages.Add(int.Parse(splitstring[i + 2]));
            }
            FirstNames = firstnames;
            LastNames = lastnames;
            Ages = ages;
        }

        public static Persons FindOldestPerson(List<Persons> persons) {
            return;
        }
    }
}
