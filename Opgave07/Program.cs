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


//opgave 7.5
Console.WriteLine("Udskriver det laveste tal først\n" +
    "Indtast to heltal og klik enter når du har skrevet et tal.");
tal1 = int.Parse(Console.ReadLine());
tal2 = int.Parse(Console.ReadLine());

if (tal1 > tal2)
    Console.WriteLine(tal2 + " " + tal1);
else
    Console.WriteLine(tal1 + " " + tal2);


// opgave 7.6