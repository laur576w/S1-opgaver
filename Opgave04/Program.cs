//opgave 4.2 & 4.3
Console.WriteLine("Skriv dit fornavn.");
string first_name = Console.ReadLine();
Console.WriteLine("Skriv dit efternavn.");
string last_name = Console.ReadLine();
Console.WriteLine($"Velkommen {first_name} {last_name} til det mest frygtindgydende REGNBUE ØEN");
Console.WriteLine("...");
Console.WriteLine("Hvor gammel er du?");
double age = double.Parse(Console.ReadLine());
Console.WriteLine($"Ahhhh du er {age} år");

//opgave 4.4 
Console.WriteLine($"Indtast venligst længden på side A og B af firkanten, {first_name}.");
Console.WriteLine("Hvor lang er side A i cm?");
Double side_a = double.Parse(Console.ReadLine());
Console.WriteLine("Hvor lang er Side B i cm?");
Double side_b = double.Parse(Console.ReadLine());
double sum = side_a * side_b;
Console.WriteLine($"Summen af firkantens areal er {sum}.");

