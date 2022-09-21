//opgave 10.1
Console.WriteLine("Her kan du få lidt at vide om grise, katte, hunde, papegøjer og undulater\n" +
    "hvilket dyr ville du gerne høre om");
string dyr = Console.ReadLine();

switch (dyr) {
    case "gris":
    case "Gris":
    case "grise":
    case "Grise":
        Console.WriteLine("Det er en gris");
        break;

    case "kat":
    case "Kat":
    case "katte":
    case "Katte":
        Console.WriteLine("Det er en kat");
        break;

    case "hund":
    case "Hund":
    case "hunde":
    case "Hunde":
        Console.WriteLine("Det er en hund");
        break;

    case "papegøje":
    case "Papegøje":
    case "papegøjer":
    case "Papegøjer":
        Console.WriteLine("Det er en papegøje");
        break;

    case "undulat":
    case "Undulat":
    case "undulater":
    case "Undulater":
        Console.WriteLine("Det er en undulat");
        break;

        default:
        Console.WriteLine("Hvad siger du var det en af mulighederne");
        break;
}
Console.WriteLine();

//opgave 10.2
Console.WriteLine("7 trins skalaen\n" +
    "Hvad er din karakter?");
int grade = int.Parse(Console.ReadLine());

switch (grade) {
    case 12:
        Console.WriteLine("Det den bedste karakter man kan få, så du har bestået.");
        break;
    case 10:
        Console.WriteLine("Det er den anden bedste man kan få, bestået");
        break;
    case 7:
        Console.WriteLine("Det er den tredje bedste man kan få, bestået");
        break;
    case 4:
        Console.WriteLine("Det er den fjerde bedste man kan få, bestået");
        break;
    case 2:
        Console.WriteLine("Du har knap nok bestået");
        break;
    case 0:
        Console.WriteLine("Du har ikke bestået");
        break;
    case -3:
        Console.WriteLine("Du har ikke bestået");
        break;
    default:
        Console.WriteLine("Du har ikke skrevet en karakter som går under vores vurderings linjer");
        break;
}

