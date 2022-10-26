

namespace Person {
    internal class Persons {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public Persons(string firstname, string lastname, int age) {
            FirstName = firstname;
            LastName = lastname;
            Age = age;
        }

        public static Persons FindOldestPerson(List<Persons> persons) {
            return persons.MaxBy(p => p.Age);
        }
        public static Persons FindYoungestPerson(List<Persons> persons) {
            return persons.MinBy(p => p.Age);
        }
        public static Persons LongestFirstName(List<Persons> persons) {
            List<string> name = new();
            foreach (Persons person in persons) {
                name.Add(person.FirstName);
            }
            string[] strings = name.ToArray();

            var value = strings.Select((val, ix) => new { len = val.Length, ix })
                               .OrderByDescending(x => x.len).FirstOrDefault();

            return persons[value != null ? value.ix : -1];
        }
        public static Persons ShortestFirstName(List<Persons> persons) {
            List<string> name = new();
            foreach (Persons person in persons) {
                name.Add(person.FirstName);
            }
            string[] strings = name.ToArray();

            var value = strings.Select((val, ix) => new { len = val.Length, ix })
                               .OrderBy(x => x.len).FirstOrDefault();

            return persons[value != null ? value.ix : -1];
        }
        public static Persons LongestName(List<Persons> persons) {
            List<string> name = new();
            foreach (Persons person in persons) {
                name.Add($"{person.FirstName}{person.LastName}");
            }
            string[] strings = name.ToArray();

            var value = strings.Select((val, ix) => new { len = val.Length, ix })
                               .OrderByDescending(x => x.len).FirstOrDefault();

            return persons[value != null ? value.ix : -1];
        }
        public static Persons ShortestName(List<Persons> persons) {
            List<string> name = new();
            foreach (Persons person in persons) {
                name.Add($"{person.FirstName}{person.LastName}");
            }
            string[] strings = name.ToArray();

            var value = strings.Select((val, ix) => new { len = val.Length, ix })
                               .OrderBy(x => x.len).FirstOrDefault();

            return persons[value != null ? value.ix : -1];
        }
        public override string ToString() {
            return $"{FirstName} {LastName} {Age}"; 
        }
    }
}
