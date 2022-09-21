//Opgave 5.1
using System.Globalization;

var info = CultureInfo.InvariantCulture.Clone() as CultureInfo;
info.NumberFormat.NumberDecimalSeparator = ",";

Console.WriteLine("En simple lommeregner der kun kan bruge to numre.");
Console.WriteLine();
Console.Write("Indtast det første nummer: ");
double num1 = double.Parse(Console.ReadLine());
Console.Write("Indtast det andet nummer: ");
double num2 = double.Parse(Console.ReadLine());

double sumPl = num1 + num2;
double sumMi = num1 - num2;
double sumGa = num1 * num2;
double sumDi = num1 / num2;
double sumMo = num1 % num2;

Console.WriteLine($"Resultat af de to tal lagt sammen er: {sumPl}");
Console.WriteLine($"Resultat af de to tal trukket fra hinanden er: {sumMi}");
Console.WriteLine($"Resultat af de to tal ganget sammen er: {sumGa}");
Console.WriteLine($"Resultat af de to tal divideret med hinanden er: {sumDi}");
Console.WriteLine($"Resultat af de to tal modulo med hinandener: {sumMo}");