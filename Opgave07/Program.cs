//opgave 7.1
double discount = 0;

Console.WriteLine("Hvad er beløbet?");
double price = double.Parse(Console.ReadLine());

if (price > 1000) {
    discount = price * 0.05; //regner rabatten ud
    double disc_price = price - discount; //tager rabatten fra 
    Console.WriteLine("Du får {0} i rabat.", discount);
    Console.WriteLine("Det færdige resultat bliver {0}", disc_price);
}
else {
    Console.WriteLine("Du får ikke rabat, så det færdige beløb bliver {0}\n", price);
}


//opgave 7.2
Console.WriteLine("Indskriv to heltal men klik enter efter et tal er skrevet");
int tal1 = int.Parse(Console.ReadLine());
int tal2 = int.Parse(Console.ReadLine());

if (tal1 == tal2)
    Console.WriteLine("De to tal er ens\n");
else
    Console.WriteLine("De to tal er ikke ens\n");


//opgave 7.3
Console.WriteLine("Division med heltal.\n" +
    "Indskriv to heltal, men klik enter efter et tal er skrevet");
double input_one = double.Parse(Console.ReadLine());
double input_two = double.Parse(Console.ReadLine());

if (tal2 == 0)
    Console.WriteLine("Du kan ikke dividere med 0");

double sum = input_one / input_two; 
Console.WriteLine("Resultatet er: {0}\n", sum);


//opgave 7.4
Console.WriteLine("Udskriver det højeste tal af to tal\n" +
    "Indtast to heltal og klik enter når du har skrevet et tal.");
tal1 = int.Parse(Console.ReadLine());
tal2 = int.Parse(Console.ReadLine());

if (tal1 < tal2) //tal1 mindre end tal2
    Console.WriteLine("Det største tal er {0}", tal2);
else if (tal1 > tal2) //tal1 støre end tal2
    Console.WriteLine("Det største tal er {0}", tal1);
else 
    Console.WriteLine("Talene er ens");

Console.WriteLine();


//opgave 7.5
Console.WriteLine("Udskriver det laveste tal først\n" +
    "Indtast to heltal og klik enter når du har skrevet et tal.");
tal1 = int.Parse(Console.ReadLine());
tal2 = int.Parse(Console.ReadLine());

if (tal1 > tal2)
    Console.WriteLine(tal2 + " " + tal1);
else
    Console.WriteLine(tal1 + " " + tal2);

Console.WriteLine();


// opgave 7.6
Console.WriteLine("Er tallet positivt, negativt eller 0\n" +
    "Indtast tallet og klik enter");
tal1 = int.Parse(Console.ReadLine());

if (tal1 < 0)
    Console.WriteLine("Tallet er negativ.");
else if (tal1 > 0)
    Console.WriteLine("Tallet er positivt");
else
    Console.WriteLine("Tallet er 0");

Console.WriteLine();

//opgave 7.7 & 7.8
double pris;
double express = 1;

Console.WriteLine("Hvor meget vejer brevet?");
double weight = double.Parse(Console.ReadLine());
Console.WriteLine("Skal det sendes med express?\n" +
    "1 for ja og 0 for nej.");
bool answer = bool.Parse(Console.ReadLine());

if (answer == true)
    express = 1.50;


switch (weight) {
    case < 20:
        pris = 5 * express;
        Console.WriteLine("Du skal betale {0}kr", pris);
        break;
    case < 50:
        pris = 7 * express;
        Console.WriteLine("Du skal betale {0}kr", pris);
        break;
    case < 100:
        pris = 10 * express;
        Console.WriteLine("Du skal betale {0}kr", pris);
        break;
    case < 150:
        pris = 15 * express;
        Console.WriteLine("Du skal betale {0}kr", pris);
        break;
    case < 200:
        pris = 20 * express;
        Console.WriteLine("Du skal betale {0}kr", pris);
        break;
    case > 199:
        pris = 30 * express;
        Console.WriteLine("Du skal betale {0}kr", pris);
        break;
}